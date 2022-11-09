// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support
{

    /// <summary>Provisioning state of the Private Endpoint Connection.</summary>
    public partial struct EndPointProvisioningState :
        System.IEquatable<EndPointProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState Updating = @"Updating";

        /// <summary>the value for an instance of the <see cref="EndPointProvisioningState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to EndPointProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EndPointProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new EndPointProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="EndPointProvisioningState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private EndPointProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type EndPointProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type EndPointProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is EndPointProvisioningState && Equals((EndPointProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum EndPointProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for EndPointProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to EndPointProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EndPointProvisioningState" />.</param>

        public static implicit operator EndPointProvisioningState(string value)
        {
            return new EndPointProvisioningState(value);
        }

        /// <summary>Implicit operator to convert EndPointProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="EndPointProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum EndPointProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum EndPointProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.EndPointProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}