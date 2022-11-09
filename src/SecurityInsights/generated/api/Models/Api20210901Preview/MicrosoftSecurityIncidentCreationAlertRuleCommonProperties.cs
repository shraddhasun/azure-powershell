// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>MicrosoftSecurityIncidentCreation rule common property bag.</summary>
    public partial class MicrosoftSecurityIncidentCreationAlertRuleCommonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMicrosoftSecurityIncidentCreationAlertRuleCommonProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMicrosoftSecurityIncidentCreationAlertRuleCommonPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayNamesExcludeFilter" /> property.</summary>
        private string[] _displayNamesExcludeFilter;

        /// <summary>the alerts' displayNames on which the cases will not be generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] DisplayNamesExcludeFilter { get => this._displayNamesExcludeFilter; set => this._displayNamesExcludeFilter = value; }

        /// <summary>Backing field for <see cref="DisplayNamesFilter" /> property.</summary>
        private string[] _displayNamesFilter;

        /// <summary>the alerts' displayNames on which the cases will be generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] DisplayNamesFilter { get => this._displayNamesFilter; set => this._displayNamesFilter = value; }

        /// <summary>Backing field for <see cref="ProductFilter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.MicrosoftSecurityProductName _productFilter;

        /// <summary>The alerts' productName on which the cases will be generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.MicrosoftSecurityProductName ProductFilter { get => this._productFilter; set => this._productFilter = value; }

        /// <summary>Backing field for <see cref="SeveritiesFilter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity[] _severitiesFilter;

        /// <summary>the alerts' severities on which the cases will be generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity[] SeveritiesFilter { get => this._severitiesFilter; set => this._severitiesFilter = value; }

        /// <summary>
        /// Creates an new <see cref="MicrosoftSecurityIncidentCreationAlertRuleCommonProperties" /> instance.
        /// </summary>
        public MicrosoftSecurityIncidentCreationAlertRuleCommonProperties()
        {

        }
    }
    /// MicrosoftSecurityIncidentCreation rule common property bag.
    public partial interface IMicrosoftSecurityIncidentCreationAlertRuleCommonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>the alerts' displayNames on which the cases will not be generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the alerts' displayNames on which the cases will not be generated",
        SerializedName = @"displayNamesExcludeFilter",
        PossibleTypes = new [] { typeof(string) })]
        string[] DisplayNamesExcludeFilter { get; set; }
        /// <summary>the alerts' displayNames on which the cases will be generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the alerts' displayNames on which the cases will be generated",
        SerializedName = @"displayNamesFilter",
        PossibleTypes = new [] { typeof(string) })]
        string[] DisplayNamesFilter { get; set; }
        /// <summary>The alerts' productName on which the cases will be generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The alerts' productName on which the cases will be generated",
        SerializedName = @"productFilter",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.MicrosoftSecurityProductName) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.MicrosoftSecurityProductName ProductFilter { get; set; }
        /// <summary>the alerts' severities on which the cases will be generated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the alerts' severities on which the cases will be generated",
        SerializedName = @"severitiesFilter",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity[] SeveritiesFilter { get; set; }

    }
    /// MicrosoftSecurityIncidentCreation rule common property bag.
    internal partial interface IMicrosoftSecurityIncidentCreationAlertRuleCommonPropertiesInternal

    {
        /// <summary>the alerts' displayNames on which the cases will not be generated</summary>
        string[] DisplayNamesExcludeFilter { get; set; }
        /// <summary>the alerts' displayNames on which the cases will be generated</summary>
        string[] DisplayNamesFilter { get; set; }
        /// <summary>The alerts' productName on which the cases will be generated</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.MicrosoftSecurityProductName ProductFilter { get; set; }
        /// <summary>the alerts' severities on which the cases will be generated</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.AlertSeverity[] SeveritiesFilter { get; set; }

    }
}