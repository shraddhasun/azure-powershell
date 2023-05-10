#
# Module manifest for module 'AzPreview'
#
# Generated by: Microsoft Corporation
#
# Generated on: 5/17/2021
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '9.5.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '5052d1e8-69f1-4f91-8433-5400429b2db9'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Including stable version and preview version of Azure PowerShell modules. This module is compatible with PowerShell and Windows PowerShell.
For more information about the AzPreview module, please visit the following: https://learn.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.12.1'; }, 
            @{ModuleName = 'Az.ADDomainServices'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.Advisor'; RequiredVersion = '2.0.0'; }, 
            @{ModuleName = 'Az.Aks'; RequiredVersion = '5.3.1'; }, 
            @{ModuleName = 'Az.AlertsManagement'; RequiredVersion = '0.5.0'; }, 
            @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
            @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '4.0.2'; }, 
            @{ModuleName = 'Az.App'; RequiredVersion = '0.1.1'; }, 
            @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.2.0'; }, 
            @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '2.2.2'; }, 
            @{ModuleName = 'Az.ArcResourceBridge'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.Attestation'; RequiredVersion = '2.0.0'; }, 
            @{ModuleName = 'Az.Automanage'; RequiredVersion = '1.0.0'; }, 
            @{ModuleName = 'Az.Automation'; RequiredVersion = '1.9.1'; }, 
            @{ModuleName = 'Az.BareMetal'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.Batch'; RequiredVersion = '3.3.0'; }, 
            @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
            @{ModuleName = 'Az.BillingBenefits'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.Blueprint'; RequiredVersion = '0.4.2'; }, 
            @{ModuleName = 'Az.BotService'; RequiredVersion = '0.5.0'; }, 
            @{ModuleName = 'Az.Cdn'; RequiredVersion = '2.1.0'; }, 
            @{ModuleName = 'Az.ChangeAnalysis'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.CloudService'; RequiredVersion = '1.2.0'; }, 
            @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.13.0'; }, 
            @{ModuleName = 'Az.Communication'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.Compute'; RequiredVersion = '5.6.0'; }, 
            @{ModuleName = 'Az.ConfidentialLedger'; RequiredVersion = '1.0.0'; }, 
            @{ModuleName = 'Az.Confluent'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.ConnectedKubernetes'; RequiredVersion = '0.9.0'; }, 
            @{ModuleName = 'Az.ConnectedMachine'; RequiredVersion = '0.4.1'; }, 
            @{ModuleName = 'Az.ConnectedNetwork'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '3.2.0'; }, 
            @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '3.0.2'; }, 
            @{ModuleName = 'Az.CostManagement'; RequiredVersion = '0.3.0'; }, 
            @{ModuleName = 'Az.CustomLocation'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.CustomProviders'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.Dashboard'; RequiredVersion = '0.1.1'; }, 
            @{ModuleName = 'Az.DataBox'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
            @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.5.0'; }, 
            @{ModuleName = 'Az.Datadog'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.16.13'; }, 
            @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
            @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.0'; }, 
            @{ModuleName = 'Az.DataMigration'; RequiredVersion = '0.12.1'; }, 
            @{ModuleName = 'Az.DataProtection'; RequiredVersion = '1.1.0'; }, 
            @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.1'; }, 
            @{ModuleName = 'Az.DedicatedHsm'; RequiredVersion = '0.3.0'; }, 
            @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
            @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '3.1.1'; }, 
            @{ModuleName = 'Az.DeviceProvisioningServices'; RequiredVersion = '0.10.0'; }, 
            @{ModuleName = 'Az.DeviceUpdate'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.DevSpaces'; RequiredVersion = '0.7.3'; }, 
            @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
            @{ModuleName = 'Az.DigitalTwins'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.DiskPool'; RequiredVersion = '0.3.0'; }, 
            @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
            @{ModuleName = 'Az.DnsResolver'; RequiredVersion = '0.2.1'; }, 
            @{ModuleName = 'Az.DynatraceObservability'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.EdgeOrder'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.Elastic'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.ElasticSan'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.5.0'; }, 
            @{ModuleName = 'Az.EventHub'; RequiredVersion = '3.2.2'; }, 
            @{ModuleName = 'Az.FluidRelay'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.10.0'; }, 
            @{ModuleName = 'Az.Functions'; RequiredVersion = '4.0.6'; }, 
            @{ModuleName = 'Az.GuestConfiguration'; RequiredVersion = '0.11.0'; }, 
            @{ModuleName = 'Az.HanaOnAzure'; RequiredVersion = '0.3.0'; }, 
            @{ModuleName = 'Az.HDInsight'; RequiredVersion = '5.0.1'; }, 
            @{ModuleName = 'Az.HealthBot'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '2.0.0'; }, 
            @{ModuleName = 'Az.HPCCache'; RequiredVersion = '0.1.1'; }, 
            @{ModuleName = 'Az.ImageBuilder'; RequiredVersion = '0.3.0'; }, 
            @{ModuleName = 'Az.ImportExport'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.IotCentral'; RequiredVersion = '0.10.0'; }, 
            @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.5'; }, 
            @{ModuleName = 'Az.KeyVault'; RequiredVersion = '4.9.2'; }, 
            @{ModuleName = 'Az.KubernetesConfiguration'; RequiredVersion = '0.6.0'; }, 
            @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.1.0'; }, 
            @{ModuleName = 'Az.LabServices'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.LoadTesting'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.0'; }, 
            @{ModuleName = 'Az.Logz'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
            @{ModuleName = 'Az.MachineLearningServices'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.2.1'; }, 
            @{ModuleName = 'Az.ManagedServiceIdentity'; RequiredVersion = '1.1.1'; }, 
            @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '3.0.0'; }, 
            @{ModuleName = 'Az.ManagementPartner'; RequiredVersion = '0.7.2'; }, 
            @{ModuleName = 'Az.Maps'; RequiredVersion = '0.8.0'; }, 
            @{ModuleName = 'Az.MariaDb'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.Marketplace'; RequiredVersion = '0.3.0'; }, 
            @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '2.0.0'; }, 
            @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
            @{ModuleName = 'Az.Migrate'; RequiredVersion = '2.1.0'; }, 
            @{ModuleName = 'Az.MixedReality'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.MobileNetwork'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.Monitor'; RequiredVersion = '4.4.1'; }, 
            @{ModuleName = 'Az.MonitoringSolutions'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.MySql'; RequiredVersion = '1.1.0'; }, 
            @{ModuleName = 'Az.NetAppFiles'; RequiredVersion = '0.11.1'; }, 
            @{ModuleName = 'Az.Network'; RequiredVersion = '5.5.0'; }, 
            @{ModuleName = 'Az.NetworkFunction'; RequiredVersion = '0.1.2'; }, 
            @{ModuleName = 'Az.Nginx'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
            @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '3.2.0'; }, 
            @{ModuleName = 'Az.Orbital'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.Peering'; RequiredVersion = '0.4.0'; }, 
            @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.6.0'; }, 
            @{ModuleName = 'Az.Portal'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.PostgreSql'; RequiredVersion = '1.1.0'; }, 
            @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.2.0'; }, 
            @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
            @{ModuleName = 'Az.ProviderHub'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.Purview'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.Quota'; RequiredVersion = '0.1.0'; }, 
            @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '6.3.0'; }, 
            @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.7.1'; }, 
            @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.1.0'; }, 
            @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.4'; }, 
            @{ModuleName = 'Az.Reservations'; RequiredVersion = '0.11.0'; }, 
            @{ModuleName = 'Az.ResourceGraph'; RequiredVersion = '0.13.0'; }, 
            @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.1.0'; }, 
            @{ModuleName = 'Az.Resources'; RequiredVersion = '6.5.3'; }, 
            @{ModuleName = 'Az.Search'; RequiredVersion = '0.8.0'; }, 
            @{ModuleName = 'Az.Security'; RequiredVersion = '1.4.0'; }, 
            @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '3.0.1'; }, 
            @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '2.2.0'; }, 
            @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.1.1'; }, 
            @{ModuleName = 'Az.ServiceLinker'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.5.0'; }, 
            @{ModuleName = 'Az.SpringCloud'; RequiredVersion = '0.3.0'; }, 
            @{ModuleName = 'Az.Sql'; RequiredVersion = '4.4.0'; }, 
            @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
            @{ModuleName = 'Az.Ssh'; RequiredVersion = '0.1.1'; }, 
            @{ModuleName = 'Az.StackHCI'; RequiredVersion = '1.4.3'; }, 
            @{ModuleName = 'Az.Storage'; RequiredVersion = '5.4.1'; }, 
            @{ModuleName = 'Az.StorageMover'; RequiredVersion = '1.0.0'; }, 
            @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.7.0'; }, 
            @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.0.0'; }, 
            @{ModuleName = 'Az.Subscription'; RequiredVersion = '0.9.0'; }, 
            @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
            @{ModuleName = 'Az.Synapse'; RequiredVersion = '2.3.0'; }, 
            @{ModuleName = 'Az.TimeSeriesInsights'; RequiredVersion = '0.2.0'; }, 
            @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.2.0'; }, 
            @{ModuleName = 'Az.VMware'; RequiredVersion = '0.5.0'; }, 
            @{ModuleName = 'Az.VoiceServices'; RequiredVersion = '0.1.1'; }, 
            @{ModuleName = 'Az.Websites'; RequiredVersion = '2.13.0'; }, 
            @{ModuleName = 'Az.WindowsIotServices'; RequiredVersion = '0.1.0'; })

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
        ReleaseNotes = 'https://aka.ms/azpspreview'

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

