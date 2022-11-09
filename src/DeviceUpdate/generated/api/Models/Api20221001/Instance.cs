// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Device Update instance details.</summary>
    public partial class Instance :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstance,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.TrackedResource();

        /// <summary>Parent Device Update Account name which Instance belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 0)]
        public string AccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).AccountName; }

        /// <summary>Authentication Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string DiagnosticStoragePropertyAuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStoragePropertyAuthenticationType; }

        /// <summary>ConnectionString of the diagnostic storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string DiagnosticStoragePropertyConnectionString { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStoragePropertyConnectionString; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStoragePropertyConnectionString = value ?? null; }

        /// <summary>ResourceId of the diagnostic storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string DiagnosticStoragePropertyResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStoragePropertyResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStoragePropertyResourceId = value ?? null; }

        /// <summary>Enables or Disables the diagnostic logs collection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public bool? EnableDiagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).EnableDiagnostic; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).EnableDiagnostic = value ?? default(bool); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Id; }

        /// <summary>List of IoT Hubs associated with the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IIotHubSettings[] IotHub { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).IotHub; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).IotHub = value ?? null /* arrayOf */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 2)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for AccountName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceInternal.AccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).AccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).AccountName = value; }

        /// <summary>Internal Acessors for DiagnosticStorageProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IDiagnosticStorageProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceInternal.DiagnosticStorageProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStorageProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStorageProperty = value; }

        /// <summary>Internal Acessors for DiagnosticStoragePropertyAuthenticationType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceInternal.DiagnosticStoragePropertyAuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStoragePropertyAuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).DiagnosticStoragePropertyAuthenticationType = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.InstanceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 1)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceProperties _property;

        /// <summary>Device Update instance properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.InstanceProperties()); set => this._property = value; }

        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstancePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 3)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Instance" /> instance.</summary>
        public Instance()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Device Update instance details.
    public partial interface IInstance :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResource
    {
        /// <summary>Parent Device Update Account name which Instance belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Parent Device Update Account name which Instance belongs to.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get;  }
        /// <summary>Authentication Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Authentication Type",
        SerializedName = @"authenticationType",
        PossibleTypes = new [] { typeof(string) })]
        string DiagnosticStoragePropertyAuthenticationType { get;  }
        /// <summary>ConnectionString of the diagnostic storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ConnectionString of the diagnostic storage account",
        SerializedName = @"connectionString",
        PossibleTypes = new [] { typeof(string) })]
        string DiagnosticStoragePropertyConnectionString { get; set; }
        /// <summary>ResourceId of the diagnostic storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ResourceId of the diagnostic storage account",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DiagnosticStoragePropertyResourceId { get; set; }
        /// <summary>Enables or Disables the diagnostic logs collection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enables or Disables the diagnostic logs collection",
        SerializedName = @"enableDiagnostics",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableDiagnostic { get; set; }
        /// <summary>List of IoT Hubs associated with the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of IoT Hubs associated with the account.",
        SerializedName = @"iotHubs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IIotHubSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IIotHubSettings[] IotHub { get; set; }
        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Device Update instance details.
    internal partial interface IInstanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api30.ITrackedResourceInternal
    {
        /// <summary>Parent Device Update Account name which Instance belongs to.</summary>
        string AccountName { get; set; }
        /// <summary>Customer-initiated diagnostic log collection storage properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IDiagnosticStorageProperties DiagnosticStorageProperty { get; set; }
        /// <summary>Authentication Type</summary>
        string DiagnosticStoragePropertyAuthenticationType { get; set; }
        /// <summary>ConnectionString of the diagnostic storage account</summary>
        string DiagnosticStoragePropertyConnectionString { get; set; }
        /// <summary>ResourceId of the diagnostic storage account</summary>
        string DiagnosticStoragePropertyResourceId { get; set; }
        /// <summary>Enables or Disables the diagnostic logs collection</summary>
        bool? EnableDiagnostic { get; set; }
        /// <summary>List of IoT Hubs associated with the account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IIotHubSettings[] IotHub { get; set; }
        /// <summary>Device Update instance properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.Api20221001.IInstanceProperties Property { get; set; }
        /// <summary>Provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}