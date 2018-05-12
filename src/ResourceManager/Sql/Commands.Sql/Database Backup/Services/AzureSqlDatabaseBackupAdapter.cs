// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Sql.Backup.Model;
using Microsoft.Azure.Commands.Sql.Database.Model;
using Microsoft.Azure.Commands.Sql.Database.Services;
using Microsoft.Azure.Commands.Sql.ElasticPool.Services;
using Microsoft.Azure.Commands.Sql.Server.Adapter;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Microsoft.Azure.Commands.Sql.Backup.Services
{
    /// <summary>
    /// Adapter for database backup operations
    /// </summary>
    public class AzureSqlDatabaseBackupAdapter
    {
        /// <summary>
        /// Gets or sets the AzureSqlDatabaseBackupCommunicator which has all the needed management clients
        /// </summary>
        private AzureSqlDatabaseBackupCommunicator Communicator { get; set; }

        /// <summary>
        /// Gets or sets the Azure profile
        /// </summary>
        public IAzureContext Context { get; set; }

        /// <summary>
        /// Gets or sets the Azure Subscription
        /// </summary>
        private IAzureSubscription _subscription { get; set; }

        /// <summary>
        /// Constructs a database backup adapter
        /// </summary>
        /// <param name="profile">The current azure profile</param>
        /// <param name="subscription">The current azure subscription</param>
        public AzureSqlDatabaseBackupAdapter(IAzureContext context)
        {
            Context = context;
            _subscription = context.Subscription;
            Communicator = new AzureSqlDatabaseBackupCommunicator(Context);
        }

        /// <summary>
        /// Lists the restore points for a given Sql Azure Database.
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL database</param>
        /// <returns>List of restore points</returns>
        internal IEnumerable<AzureSqlDatabaseRestorePointModel> ListRestorePoints(string resourceGroup, string serverName, string databaseName)
        {
            var resp = Communicator.ListRestorePoints(resourceGroup, serverName, databaseName);
            return resp.Select((restorePoint) =>
            {
                return new AzureSqlDatabaseRestorePointModel()
                {
                    ResourceGroupName = resourceGroup,
                    ServerName = serverName,
                    DatabaseName = databaseName,
                    Location = restorePoint.Location,
                    RestorePointType = restorePoint.RestorePointType.ToString(),
                    RestorePointCreationDate = restorePoint.RestorePointCreationDate,
                    EarliestRestoreDate = restorePoint.EarliestRestoreDate,
                    RestorePointLabel = restorePoint.RestorePointLabel
                };
            }).ToList();
        }

        /// <summary>
        /// Creates a new the restore point for a given Sql Azure Database.
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL database</param>
        /// <returns>List of restore points</returns>
        internal IEnumerable<AzureSqlDatabaseRestorePointModel> NewRestorePoint(IEnumerable<AzureSqlDatabaseRestorePointModel> entityList)
        {
            AzureSqlDatabaseRestorePointModel entity = entityList.Single();
            Management.Sql.Models.CreateDatabaseRestorePointDefinition definition = new Management.Sql.Models.CreateDatabaseRestorePointDefinition { RestorePointLabel = entity.RestorePointLabel };
            var resp = Communicator.NewRestorePoint(entity.ResourceGroupName, entity.ServerName, entity.DatabaseName, definition);
            return new List<AzureSqlDatabaseRestorePointModel>
            {
                new AzureSqlDatabaseRestorePointModel()
                {
                    ResourceGroupName = entity.ResourceGroupName,
                    ServerName = entity.ServerName,
                    DatabaseName = entity.DatabaseName,
                    Location = resp.Location,
                    RestorePointType = resp.RestorePointType.ToString(),
                    RestorePointCreationDate = resp.RestorePointCreationDate,
                    EarliestRestoreDate = resp.EarliestRestoreDate,
                    RestorePointLabel = resp.RestorePointLabel
                }
            };
        }

        /// <summary>
        /// Removes a given restore point for a given Sql Azure Database.
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL database</param>
        /// <param name="restorePointCreationDate">The create time of the restore point</param>
        /// <returns>void</returns>
        internal void RemoveRestorePoint(IEnumerable<AzureSqlDatabaseRestorePointModel> entityList)
        {
            AzureSqlDatabaseRestorePointModel entity = entityList.Single();
            string restorePointName = entity.RestorePointCreationDate.Value.ToFileTimeUtc().ToString();
            Communicator.RemoveRestorePoint(entity.ResourceGroupName, entity.ServerName, entity.DatabaseName, restorePointName);
        }

        /// <summary>
        /// Lists the recoverable databases (geo backups) for a given Sql Azure Server.
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <returns>List of geo backups</returns>
        internal ICollection<AzureSqlDatabaseGeoBackupModel> ListGeoBackups(string resourceGroup, string serverName)
        {
            var resp = Communicator.ListGeoBackups(resourceGroup, serverName);
            return resp.Select((geoBackup) =>
            {
                return new AzureSqlDatabaseGeoBackupModel()
                {
                    ResourceGroupName = resourceGroup,
                    DatabaseName = geoBackup.Name,
                    ServerName = serverName,
                    ResourceId = geoBackup.Id,
                    Edition = geoBackup.Properties.Edition,
                    LastAvailableBackupDate = geoBackup.Properties.LastAvailableBackupDate
                };
            }).ToList();
        }

        /// <summary>
        /// Lists the restorable deleted databases for a given Sql Azure Server.
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <returns>List of restorable deleted databases</returns>
        internal ICollection<AzureSqlDeletedDatabaseBackupModel> ListDeletedDatabaseBackups(string resourceGroup, string serverName)
        {
            var resp = Communicator.ListDeletedDatabaseBackups(resourceGroup, serverName);
            return resp.Select((deletedDatabaseBackup) =>
            {
                return new AzureSqlDeletedDatabaseBackupModel()
                {
                    ResourceGroupName = resourceGroup,
                    ServerName = serverName,
                    DatabaseName = deletedDatabaseBackup.Properties.DatabaseName,
                    Edition = deletedDatabaseBackup.Properties.Edition,
                    MaxSizeBytes = deletedDatabaseBackup.Properties.MaxSizeBytes,
                    ServiceLevelObjective = deletedDatabaseBackup.Properties.ServiceLevelObjective,
                    ElasticPoolName = deletedDatabaseBackup.Properties.ElasticPoolName,
                    CreationDate = deletedDatabaseBackup.Properties.CreationDate,
                    DeletionDate = deletedDatabaseBackup.Properties.DeletionDate,
                    RecoveryPeriodStartDate = deletedDatabaseBackup.Properties.EarliestRestoreDate,
                    ResourceId = deletedDatabaseBackup.Id,
                };
            }).ToList();
        }

        /// <summary>
        /// Get a recoverable databases (geo backup) for a given Sql Azure Database.
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL Database</param>
        /// <returns>A geo backup</returns>
        internal AzureSqlDatabaseGeoBackupModel GetGeoBackup(string resourceGroup, string serverName, string databaseName)
        {
            var geoBackup = Communicator.GetGeoBackup(resourceGroup, serverName, databaseName);
            return new AzureSqlDatabaseGeoBackupModel()
            {
                ResourceGroupName = resourceGroup,
                DatabaseName = geoBackup.Name,
                ServerName = serverName,
                ResourceId = geoBackup.Id,
                Edition = geoBackup.Properties.Edition,
                LastAvailableBackupDate = geoBackup.Properties.LastAvailableBackupDate,
            };
        }

        /// <summary>
        /// Get a restorable deleted databases for a given Sql Azure Database.
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL Database</param>
        /// <returns>A restorable deleted database</returns>
        internal AzureSqlDeletedDatabaseBackupModel GetDeletedDatabaseBackup(string resourceGroup, string serverName, string databaseName)
        {
            var deletedDatabaseBackup = Communicator.GetDeletedDatabaseBackup(resourceGroup, serverName, databaseName);
            return new AzureSqlDeletedDatabaseBackupModel()
            {
                ResourceGroupName = resourceGroup,
                ServerName = serverName,
                DatabaseName = deletedDatabaseBackup.Properties.DatabaseName,
                Edition = deletedDatabaseBackup.Properties.Edition,
                MaxSizeBytes = deletedDatabaseBackup.Properties.MaxSizeBytes,
                ServiceLevelObjective = deletedDatabaseBackup.Properties.ServiceLevelObjective,
                ElasticPoolName = deletedDatabaseBackup.Properties.ElasticPoolName,
                CreationDate = deletedDatabaseBackup.Properties.CreationDate,
                DeletionDate = deletedDatabaseBackup.Properties.DeletionDate,
                RecoveryPeriodStartDate = deletedDatabaseBackup.Properties.EarliestRestoreDate,
                ResourceId = deletedDatabaseBackup.Id,
            };
        }

        /// <summary>
        /// Get a backup LongTermRetention vault for a given Azure SQL Server
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <returns>A backup vault</returns>
        internal AzureSqlServerBackupLongTermRetentionVaultModel GetBackupLongTermRetentionVault(
            string resourceGroup, 
            string serverName)
        {
            var baVault = Communicator.GetBackupLongTermRetentionVault(
                resourceGroup,
                serverName,
                "RegisteredVault");
            return new AzureSqlServerBackupLongTermRetentionVaultModel()
            {
                Location = baVault.Location,
                ResourceGroupName = resourceGroup,
                ServerName = serverName,
                RecoveryServicesVaultResourceId = baVault.Properties.RecoveryServicesVaultResourceId,
            };
        }

        /// <summary>
        /// Get a backup LongTermRetention policy for a Azure SQL Database
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL Database</param>
        /// <param name="current">Whether or not the user provided the Current switch to get the current implementation of LTR policy</param>
        /// <returns>A backup LongTermRetention policy</returns>
        internal AzureSqlDatabaseBackupLongTermRetentionPolicyModel GetDatabaseBackupLongTermRetentionPolicy(
            string resourceGroup,
            string serverName,
            string databaseName,
            bool current)
        {
            if (!current)
            {
                var baPolicy = Communicator.GetDatabaseBackupLongTermRetentionPolicy(
                    resourceGroup,
                    serverName,
                    databaseName,
                    "Default");
                return new AzureSqlDatabaseBackupLongTermRetentionPolicyModel()
                {
                    Location = baPolicy.Location,
                    ResourceGroupName = resourceGroup,
                    ServerName = serverName,
                    DatabaseName = databaseName,
                    State = baPolicy.Properties.State,
                    RecoveryServicesBackupPolicyResourceId = baPolicy.Properties.RecoveryServicesBackupPolicyResourceId,
                };
            }
            else
            {
                Management.Sql.Models.BackupLongTermRetentionPolicy response = Communicator.GetDatabaseLongTermRetentionPolicy(
                    resourceGroup,
                    serverName,
                    databaseName);
                return new AzureSqlDatabaseBackupLongTermRetentionPolicyModel()
                {
                    ResourceGroupName = resourceGroup,
                    ServerName = serverName,
                    DatabaseName = databaseName,
                    WeeklyRetention = response.WeeklyRetention,
                    MonthlyRetention = response.MonthlyRetention,
                    YearlyRetention = response.YearlyRetention,
                    WeekOfYear = response.WeekOfYear
                };
            }
        }

        /// <summary>
        /// Create or update a backup LongTermRetention vault for a given Azure SQL Server
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <returns>A backup vault</returns>
        internal AzureSqlServerBackupLongTermRetentionVaultModel SetBackupLongTermRetentionVault(
            string resourceGroup,
            string serverName,
            AzureSqlServerBackupLongTermRetentionVaultModel model)
        {
            var baVault = Communicator.SetBackupLongTermRetentionVault(
                resourceGroup,
                serverName,
                "RegisteredVault",
                new BackupLongTermRetentionVaultCreateOrUpdateParameters()
            {
                Location = model.Location,
                Properties = new BackupLongTermRetentionVaultProperties()
                {
                    RecoveryServicesVaultResourceId = model.RecoveryServicesVaultResourceId
                }
            });
            return new AzureSqlServerBackupLongTermRetentionVaultModel()
            {
                Location = baVault.Location,
                ResourceGroupName = resourceGroup,
                ServerName = serverName,
                RecoveryServicesVaultResourceId = baVault.Properties.RecoveryServicesVaultResourceId,
            };
        }

        /// <summary>
        /// Create or update a backup LongTermRetention policy for a Azure SQL Database
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL Database</param>
        /// <returns>A backup LongTermRetention policy</returns>
        internal AzureSqlDatabaseBackupLongTermRetentionPolicyModel SetDatabaseBackupLongTermRetentionPolicy(
            string resourceGroup,
            string serverName,
            string databaseName,
            AzureSqlDatabaseBackupLongTermRetentionPolicyModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.RecoveryServicesBackupPolicyResourceId))
            {
                var baPolicy = Communicator.SetDatabaseBackupLongTermRetentionPolicy(
                    resourceGroup,
                    serverName,
                    databaseName,
                    "Default",
                    new DatabaseBackupLongTermRetentionPolicyCreateOrUpdateParameters()
                    {
                        Location = model.Location,
                        Properties = new DatabaseBackupLongTermRetentionPolicyProperties()
                        {
                            State = model.State,
                            RecoveryServicesBackupPolicyResourceId = model.RecoveryServicesBackupPolicyResourceId,
                        }
                    });
                return new AzureSqlDatabaseBackupLongTermRetentionPolicyModel()
                {
                    Location = baPolicy.Location,
                    ResourceGroupName = resourceGroup,
                    ServerName = serverName,
                    DatabaseName = databaseName,
                    State = baPolicy.Properties.State,
                    RecoveryServicesBackupPolicyResourceId = baPolicy.Properties.RecoveryServicesBackupPolicyResourceId,
                };
            }
            else
            {
                Management.Sql.Models.BackupLongTermRetentionPolicy response = Communicator.SetDatabaseLongTermRetentionPolicy(
                    resourceGroup,
                    serverName,
                    databaseName,
                    new Management.Sql.Models.BackupLongTermRetentionPolicy()
                    {
                        WeeklyRetention = model.WeeklyRetention,
                        MonthlyRetention = model.MonthlyRetention,
                        YearlyRetention = model.YearlyRetention,
                        WeekOfYear = model.WeekOfYear
                    });
                return new AzureSqlDatabaseBackupLongTermRetentionPolicyModel()
                {
                    ResourceGroupName = resourceGroup,
                    ServerName = serverName,
                    DatabaseName = databaseName,
                    WeeklyRetention = response.WeeklyRetention,
                    MonthlyRetention = response.MonthlyRetention,
                    YearlyRetention = response.YearlyRetention,
                    WeekOfYear = response.WeekOfYear
                };
            }
        }

        /// <summary>
        /// Gets the Long Term Retention backups.
        /// </summary>
        /// <param name="locationName">The location name.</param>
        /// <param name="serverName">The server name.</param>
        /// <param name="databaseName">The database name.</param>
        /// <param name="backupName">The backup name.</param>
        /// <param name="onlyLatestPerDatabase">Whether or not to only get the latest backup per database.</param>
        /// <param name="databaseState">The state of databases to get backups for: All, Live, Deleted.</param>
        internal IEnumerable<AzureSqlDatabaseLongTermRetentionBackupModel> GetDatabaseLongTermRetentionBackups(
            string locationName,
            string serverName,
            string databaseName,
            string backupName,
            bool? onlyLatestPerDatabase,
            string databaseState)
        {
            if (!string.IsNullOrWhiteSpace(backupName))
            {
                return new List<AzureSqlDatabaseLongTermRetentionBackupModel>()
                {
                    GetBackupModel(Communicator.GetDatabaseLongTermRetentionBackup(locationName, serverName, databaseName, backupName), locationName)
                };
            }
            else
            {
                return Communicator.GetDatabaseLongTermRetentionBackups(locationName, serverName, databaseName, onlyLatestPerDatabase, databaseState)
                    .Select(b => GetBackupModel(b, locationName));
            }
        }

        private AzureSqlDatabaseLongTermRetentionBackupModel GetBackupModel(Management.Sql.Models.LongTermRetentionBackup backup, string locationName)
        {
            return new AzureSqlDatabaseLongTermRetentionBackupModel()
            {
                BackupExpirationTime = backup.BackupExpirationTime,
                BackupName = backup.Name,
                BackupTime = backup.BackupTime,
                DatabaseDeletionTime = backup.DatabaseDeletionTime,
                DatabaseName = backup.DatabaseName,
                Location = locationName,
                ResourceId = backup.Id,
                ServerCreateTime = backup.ServerCreateTime,
                ServerName = backup.ServerName
            };
        }

        /// <summary>
        /// Removes a Long Term Retention backup.
        /// </summary>
        /// <param name="locationName">The location name.</param>
        /// <param name="serverName">The server name.</param>
        /// <param name="databaseName">The database name.</param>
        /// <param name="backupName">The backup name.</param>
        internal void RemoveDatabaseLongTermRetentionBackup(
            string locationName,
            string serverName,
            string databaseName,
            string backupName)
        {
            Communicator.RemoveDatabaseLongTermRetentionBackup(locationName, serverName, databaseName, backupName);
        }

        /// <summary>
        /// Get a geo backup policy for a Azure SQL Database
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL Database</param>
        /// <returns>A geo backup policy</returns>
        internal AzureSqlDatabaseGeoBackupPolicyModel GetDatabaseGeoBackupPolicy(
            string resourceGroup,
            string serverName,
            string databaseName)
        {
            var geoBackupPolicy = Communicator.GetDatabaseGeoBackupPolicy(
                resourceGroup,
                serverName,
                databaseName,
                "Default");
            return new AzureSqlDatabaseGeoBackupPolicyModel()
            {
                Location = geoBackupPolicy.Location,
                ResourceGroupName = resourceGroup,
                ServerName = serverName,
                DatabaseName = databaseName,
                State = (AzureSqlDatabaseGeoBackupPolicyModel.GeoBackupPolicyState) Enum.Parse(
                    typeof(AzureSqlDatabaseGeoBackupPolicyModel.GeoBackupPolicyState),
                    geoBackupPolicy.Properties.State),
            };
        }

        /// <summary>
        /// Create or update a geo backup policy for a Azure SQL Database
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure SQL Server</param>
        /// <param name="databaseName">The name of the Azure SQL Database</param>
        /// <returns>A geo backup policy</returns>
        internal AzureSqlDatabaseGeoBackupPolicyModel SetDatabaseGeoBackupPolicy(
            string resourceGroup,
            string serverName,
            string databaseName,
            AzureSqlDatabaseGeoBackupPolicyModel model)
        {
            var geoBackupPolicy = Communicator.SetDatabaseGeoBackupPolicy(
                resourceGroup,
                serverName,
                databaseName,
                "Default",
                new GeoBackupPolicyCreateOrUpdateParameters()
                {
                    Location = model.Location,
                    Properties = new GeoBackupPolicyProperties()
                    {
                        State = model.State.ToString(),
                    }
                });

            return new AzureSqlDatabaseGeoBackupPolicyModel()
            {
                Location = geoBackupPolicy.Location,
                ResourceGroupName = resourceGroup,
                ServerName = serverName,
                DatabaseName = databaseName,
                State = (AzureSqlDatabaseGeoBackupPolicyModel.GeoBackupPolicyState) Enum.Parse(
                    typeof(AzureSqlDatabaseGeoBackupPolicyModel.GeoBackupPolicyState),
                    geoBackupPolicy.Properties.State),
            };
        }

        /// <summary>
        /// Restore a given Sql Azure Database
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="restorePointInTime">A point to time to restore to (for PITR and dropped DB restore)</param>
        /// <param name="resourceId">The resource ID of the DB to restore (live, geo backup, deleted database, long term retention backup, etc.)</param>
        /// <param name="model">An object modeling the database to create via restore</param>
        /// <returns>Restored database object</returns>
        internal AzureSqlDatabaseModel RestoreDatabase(string resourceGroup, DateTime restorePointInTime, string resourceId, AzureSqlDatabaseModel model)
        {
            // Construct the ARM resource Id of the pool
            string elasticPoolId = string.IsNullOrWhiteSpace(model.ElasticPoolName) ? null : AzureSqlDatabaseModel.PoolIdTemplate.FormatInvariant(
                        _subscription.Id,
                        resourceGroup,
                        model.ServerName,
                        model.ElasticPoolName);

            // Restore database
            var dbModel = new Management.Sql.Models.Database()
            {
                Location = model.Location,
                CreateMode = model.CreateMode,
                RestorePointInTime = restorePointInTime,
                ElasticPoolId = elasticPoolId,
                Sku = string.IsNullOrWhiteSpace(model.SkuName) ? null : new Management.Sql.Models.Sku()
                {
                    Name = model.SkuName,
                    Tier = model.Edition,
                    Family = model.Family,
                    Capacity = model.Capacity
                }
            };

            if(model.CreateMode.Equals(Management.Sql.Models.CreateMode.Recovery))
            {
                dbModel.SourceDatabaseId = resourceId;
                dbModel.RecoverableDatabaseId = resourceId;
                dbModel.RecoveryServicesRecoveryPointId = resourceId;
            }
            else if(model.CreateMode.Equals(Management.Sql.Models.CreateMode.Restore))
            {
                dbModel.RestorableDroppedDatabaseId = resourceId;
                dbModel.RecoveryServicesRecoveryPointId = resourceId;
            }
            else if(model.CreateMode.Equals(Management.Sql.Models.CreateMode.RestoreLongTermRetentionBackup) && resourceId.Contains("/providers/Microsoft.Sql"))
            {
                // LTR V2
                dbModel.LongTermRetentionBackupResourceId = resourceId;
                dbModel.SourceDatabaseId = resourceId;
            }
            else
            {
                dbModel.SourceDatabaseId = resourceId;
                dbModel.RecoveryServicesRecoveryPointId = resourceId;
            }

            Management.Sql.Models.Database database = Communicator.RestoreDatabase(resourceGroup, model.ServerName, model.DatabaseName, dbModel);

            return new AzureSqlDatabaseModel(resourceGroup, model.ServerName, database);
        }

        /// <summary>
        /// Gets the Location of the server.
        /// </summary>
        /// <param name="resourceGroupName">The resource group the server is in</param>
        /// <param name="serverName">The name of the server</param>
        /// <returns></returns>
        public string GetServerLocation(string resourceGroupName, string serverName)
        {
            AzureSqlServerAdapter serverAdapter = new AzureSqlServerAdapter(Context);
            var server = serverAdapter.GetServer(resourceGroupName, serverName);
            return server.Location;
        }

        /// <summary>
        /// Gets a SQL database by name
        /// </summary>
        /// <param name="resourceGroupName">The resource group the database is in</param>
        /// <param name="serverName">The name of the server</param>
        /// <param name="databaseName">The name of the database</param>
        /// <returns></returns>
        public AzureSqlDatabaseModel GetDatabase(string resourceGroupName, string serverName, string databaseName)
        {
            AzureSqlDatabaseAdapter databaseAdapter = new AzureSqlDatabaseAdapter(Context);
            return databaseAdapter.GetDatabase(resourceGroupName, serverName, databaseName);
        }
    }
}
