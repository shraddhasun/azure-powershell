
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for Dimension.
.Description
Create an in-memory object for Dimension.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.Dimension
.Link
https://learn.microsoft.com/powershell/module/az.ScheduledQueryRule/new-AzScheduledQueryRuleDimensionObject
#>
function New-AzScheduledQueryRuleDimensionObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.Dimension')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Name of the dimension.")]
        [string]
        $Name,
        [Parameter(Mandatory, HelpMessage="Operator for dimension values.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.DimensionOperator])]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Support.DimensionOperator]
        $Operator,
        [Parameter(Mandatory, HelpMessage="List of dimension values.")]
        [string[]]
        $Value
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ScheduledQueryRule.Models.Api20210801.Dimension]::New()

        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        if ($PSBoundParameters.ContainsKey('Operator')) {
            $Object.Operator = $Operator
        }
        if ($PSBoundParameters.ContainsKey('Value')) {
            $Object.Value = $Value
        }
        return $Object
    }
}

