#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 10/15/2022
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '9.0.1'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with PowerShell and Windows PowerShell.
For more information about the Az module, please visit the following: https://docs.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.10.2'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Attestation'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.8.0'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.2.1'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.CloudService'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.11.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'Az.ConfidentialLedger'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.8.2'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.16.9'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '3.1.1'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.4.1'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.9.0'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '4.0.5'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '5.0.1'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.4'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '4.8.0'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.ManagedServiceIdentity'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '4.2.0'; }, 
               @{ModuleName = 'Az.MySql'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '3.2.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.5.1'; }, 
               @{ModuleName = 'Az.PostgreSql'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '6.0.0'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.6.0'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '6.3.1'; }, 
               @{ModuleName = 'Az.Security'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.4.1'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.StackHCI'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Synapse'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '2.11.4'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '9.0.1 - October 2022
Az.Accounts
* Upgraded Azure.Core to 1.25.0 and Azure.Identity to 1.6.1
* Upgraded Microsoft.Identity.Client to 4.46.2 and Microsoft.Identity.Client.Extensions.Msal to 2.23.0
* Upgraded Microsoft.ApplicationInsights to 2.13.1
* [Breaking Change] Changed target framework of AuthenticationAssemblyLoadContext to netcoreapp3.1.
* [Breaking Change] Removed built-in environment of Azure Germany
* Supported tenant domain as input while using ''Connect-AzAccount'' with parameter ''Tenant''. [#19471]
* Used the ArgumentCompleter attribute to replace the dynamic parameters of ''Get-AzContext''. [#18041]
* Fixed issue that module cannot be imported when required file is locked [#19624]
Az.Advisor
* Bumped API version to 2020-01-01
Az.Aks
* [Breaking Change] Removed the alias ''Install-AzAksKubectl'' of ''Install-AzAksCliTool''.
Az.ApiManagement
* [Breaking Change] Changed the type of parameter ''Sku'' from Enum to String in ''Add-AzApiManagementRegion'', ''New-AzApiManagement'' and ''Update-AzApiManagementRegion''.
Az.Attestation
* [Breaking Change] Replaced ''New/Remove/Get-AzAttestation'' with ''New/Remove/Get-AzAttestationProvider''
* Added ''Get-AzAttestationDefaultProvider'' and ''Update-AzAttestationProvider''
* Upgraded API version from 2018-09-01-preview to 2020-10-01
Az.Automation
* Added cmdlets ''Remove-AzAutomationHybridRunbookWorker'', ''Remove-AzAutomationHybridRunbookWorkerGroup'', ''Set-AzAutomationHybridRunbookWorkerGroup'', ''Get-AzAutomationHybridRunbookWorker'', ''Get-AzAutomationHybridRunbookWorkerGroup'', ''Move-AzAutomationHybridRunbookWorker'', ''New-AzAutomationHybridRunbookWorker'', ''New-AzAutomationHybridRunbookWorkerGroup'' for Hybrid Runbook Worker group management.
Az.Compute
* Added the ''TimeCreated'' property to the Virtual Machine and Virtual Machine Scale Set models.
* Improved cmdlet descriptions and parameter descriptions for VM/VMSS creation.
* Added the ''BaseRegularPriorityCount'' integer property to the following cmdlets: ''New-AzVmssConfig'' and ''Update-AzVmssConfig''
* Added the ''RegularPriorityPercentage'' integer property to the following cmdlets: ''New-AzVmssConfig'' and ''Update-AzVmssConfig''
* Added Breaking Changes for Add-AzVMAdditionalUnattendContent and Get-AzGallery cmdlets
* Added ''-DiskControllerType'' property to the following cmdlets: ''New-AzVm'', ''New-AzVmss'', ''New-AzVmConfig'', ''Set-AzVmssStorageProfile''
Az.Databricks
* Upgraded API version to 2022-04-01-preview
* Modified description of ''EnableNoPublicIP'' parameter in the ''New-AzDatabricksWorkspace''. [#14381]
Az.DataFactory
* Updated ADF .Net SDK version to 6.4.0
Az.EventGrid
* Add remaining advanced filters
Az.EventHub
* Most cmdlets in Az.EventHub module have been migrated to a new format and would witness breaking changes. Please refer our migration guide https://go.microsoft.com/fwlink/?linkid=2204690 to know breaking changes in detail.
Az.Functions
* Enabled support to create Node 18 Preview and Java 17 Preview function apps (fixes issues #19184 and #18925)
* Removed the logic that checks for AzureGermanCloud in the cloud endpoints (fixes issue #19667)
* Hided generated unused cmdlets (fixes #16666)
Az.KeyVault
* Fixed the exception content swallowed issue when exception.Response is null [#19531]
Az.MarketplaceOrdering
* Upgraded API version to 2021-01-01.
Az.Migrate
* Updated ApiVersion to 2022-05-01
* Added support for pause and resume replication
* [Breaking Change] Removed unless cmdlets
Az.Monitor
* [Breaking Change] Upgraded API version for ActivityLogAlert from 2017-04-01 to 2020-10-01, affected cmdlets:
* [Breaking Change] Upgraded API version for DiagnosticSetting from 2017-05-01-preview to 2021-05-01-preview
* [Breaking Change] Upgraded API version for Autoscale from 2015-04-01 to 2022-10-01
* [Breaking Change] Upgraded API version for ScheduledQueryRule from 2018-04-16 to 2021-08-01
Az.MySql
* Added ''PublicNetworkAccess'' to ''Update-AzMySqlServer'' [#19189]
Az.Network
* Added a new endpoint switch ''AzureArcVM'' in ''New-AzNetworkWatcherConnectionMonitor''
* Updated ''New-AzVirtualNetworkGatewayConnection'' to support bypassing the ExpressRoute gateway when accessing private-links
* Updated ''Update-AzCustomIpPrefix'' to support no-internet advertise CustomIpPrefix
* Updated ''New-AzNetworkInterface'' to support create/update nic with DisableTcpStateTracking property
* Updated cmdlet to support specifying a VirtualRouterAsn on Virtual Hub
* Updated cmdlet to support specifying an ASN on VPN Gateway
* Updated ''New-AzRoutingConfiguration'' to support bypassing NVA for spoke vNet traffic
* Updated ''Update-AzCustomIpPrefix'' to support new parameters: Asn, Geo, ExpressRouteAdvertise
* Updated cmdlets to enable verification on client certificate revocation by using a new property VerifyClientRevocation in ApplicationGatewayClientAuthConfiguration
* Updated ''New-AzCustomIpPrefix'' to support IPv4 Parent/Child CustomIpPrefix creation.
* Added Uppercase Transform in New-AzApplicationGatewayFirewallCondition
* Added DdosProtectionMode parameter in New-AzPublicIpAddress
* Added ProbeThreshold parameter to Load Balancer Probe
* Updated ''New-AzApplicationGatewayFirewallPolicyManagedRuleOverride'' to support specifying an action for a managed rule override in Application Gateway WAF Policy
* Added breaking change enum values/notification for network manager cmdlets
* Added ''EnableUDPLogOptimization'' parameter to ''New-AzFirewall''
* Fixed a bug that does not return HubIPAddresses and PrivateIPAddress during a Get-AzFirewall command
* Replaced ''IdentifyTopFatFlow'' parameter with ''EnableFatFlowLogging'' parameter to ''New-AzFirewall''
* Fixed a bug not able to add MSSQL application rules to an AZURE FIREWALL POLICY
* Onboard Project AzureML Registries to Private Link Common Cmdlets
Az.RecoveryServices
* [Breaking Change] Added fix for Enable-AzRecoveryServicesBackupProtection cmdlet. Resolved the null reference issue by making policy a mandatory parameter.
* [Breaking Change] Removed status filter from Get-AzRecoveryServicesBackupContainer command
* Added SubTasks Duration for IaasVM job
Az.Resources
* Fixed NullReferenceException issue in ''New-AzRoleAssignment'' [#19793]
Az.SecurityInsights
* Changed ''Az.SecurityInsights'' to autorest-based module
Az.ServiceBus
* Most cmdlets in Az.ServiceBus module have been migrated to a new format and would witness breaking changes. Please refer our migration guide https://go.microsoft.com/fwlink/?linkid=2204584 to know breaking changes in detail.
Az.Sql
* Added new fields to the ''Get-AzSqlInstanceDatabaseLogReplay'' cmdlet
* Improved error handling in the ''Stop-AzSqlInstanceDatabaseLogReplay'' cmdlet
* Added StorageContainerIdentity parameter in the ''Start-AzSqlInstanceDatabaseLogReplay'' cmdlet
* Removed the following cmdlets: ''Clear-AzSqlServerAdvancedThreatProtectionSetting'' and ''Clear-AzSqlDatabaseAdvancedThreatProtectionSetting''
* Added the following cmdlets: ''Get-AzSqlInstanceDatabaseAdvancedThreatProtectionSetting'', ''Get-AzSqlInstanceAdvancedThreatProtectionSetting'', ''Update-AzSqlInstanceDatabaseAdvancedThreatProtectionSetting'' and ''Update-AzSqlInstanceAdvancedThreatProtectionSetting''
* Removed the following aliases: ''Enable-AzSqlServerAdvancedThreatProtection'', ''Disable-AzSqlServerAdvancedThreatProtection'', ''Get-AzSqlServerThreatDetectionSetting'', ''Remove-AzSqlServerThreatDetectionSetting'', ''Set-AzSqlServerThreatDetectionSetting'', ''Get-AzSqlDatabaseThreatDetectionSetting'', ''Set-AzSqlDatabaseThreatDetectionSetting'' and ''Remove-AzSqlDatabaseThreatDetectionSetting''
* Changed the returned object for the following cmdlets: ''Get-AzSqlServerAdvancedThreatProtectionSetting'' and ''Get-AzSqlDatabaseAdvancedThreatProtectionSetting''
* Changed the parameters for the following cmdlets: ''Update-AzSqlServerAdvancedThreatProtectionSetting'' and ''Update-AzSqlDatabaseAdvancedThreatProtectionSetting''. Only ''Enable'' parameter is now supported.
* Changed endpoint used in SQL Server and SQL Instance from AD Graph to MS Graph
Az.StackHCI
* Made GraphAccessToken parameter obsolete in Register-AzStackHCI, Unregister-AzStackHCI and Set-AzStackHCI cmdlets. This is because Az.StackHCI module does not depend on Azure AD anymore.
* Include API version for all Microsoft.AzStackHCI related AZ-Resource calls
Az.Storage
* Migrated following Azure File dataplane cmdlets from ''Microsoft.Azure.Storage.File 11.2.2'' to ''Azure.Storage.Files.Shares 12.10.0''
* Migrated Get/List blob to always use ''Azure.Storage.Blobs''
* Fix create file sas failure with file object pipeline
  * ''New-AzStorageFileSasToken''
Az.Synapse
* [Breaking Change] Updated models of Synapse Link for Azure Sql Database
* Updated ''New-AzSynapseWorkspace'' and ''Update-AzSynapseWorkspace'' to support for user assigned managed identity (UAMI) by ''-UserAssignedIdentityAction'' and ''-UserAssignedIdentityId''
* Added EnablePublicNetworkAccess parameter to ''New-AzureSynapseWorkspace'' and ''Update-AzSynapseWorkspace''
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

