// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Extensions;

    /// <summary>Represents a collection of scheduled query rule resources.</summary>
    public partial class ScheduledQueryRuleResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleResourceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleResourceCollectionInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleResourceCollectionInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Provides the link to retrieve the next set of elements.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleResource[] _value;

        /// <summary>The values for the scheduled query rule resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ScheduledQueryRuleResourceCollection" /> instance.</summary>
        public ScheduledQueryRuleResourceCollection()
        {

        }
    }
    /// Represents a collection of scheduled query rule resources.
    public partial interface IScheduledQueryRuleResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.IJsonSerializable
    {
        /// <summary>Provides the link to retrieve the next set of elements.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provides the link to retrieve the next set of elements.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The values for the scheduled query rule resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The values for the scheduled query rule resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleResource[] Value { get; set; }

    }
    /// Represents a collection of scheduled query rule resources.
    internal partial interface IScheduledQueryRuleResourceCollectionInternal

    {
        /// <summary>Provides the link to retrieve the next set of elements.</summary>
        string NextLink { get; set; }
        /// <summary>The values for the scheduled query rule resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.IScheduledQueryRuleResource[] Value { get; set; }

    }
}