// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support
{

    /// <summary>Error code of the provisioning failure</summary>
    public partial struct ProvisioningErrorCode :
        System.IEquatable<ProvisioningErrorCode>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadCustomizerType = @"BadCustomizerType";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadDistributeType = @"BadDistributeType";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadManagedImageSource = @"BadManagedImageSource";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadPirSource = @"BadPIRSource";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadSharedImageDistribute = @"BadSharedImageDistribute";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadSharedImageVersionSource = @"BadSharedImageVersionSource";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadSourceType = @"BadSourceType";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadStagingResourceGroup = @"BadStagingResourceGroup";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode BadValidatorType = @"BadValidatorType";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode NoCustomizerScript = @"NoCustomizerScript";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode NoValidatorScript = @"NoValidatorScript";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode Other = @"Other";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode ServerError = @"ServerError";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode UnsupportedCustomizerType = @"UnsupportedCustomizerType";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode UnsupportedValidatorType = @"UnsupportedValidatorType";

        /// <summary>the value for an instance of the <see cref="ProvisioningErrorCode" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ProvisioningErrorCode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProvisioningErrorCode" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ProvisioningErrorCode(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ProvisioningErrorCode</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ProvisioningErrorCode (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ProvisioningErrorCode && Equals((ProvisioningErrorCode)obj);
        }

        /// <summary>Returns hashCode for enum ProvisioningErrorCode</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ProvisioningErrorCode"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ProvisioningErrorCode(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ProvisioningErrorCode</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ProvisioningErrorCode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProvisioningErrorCode" />.</param>

        public static implicit operator ProvisioningErrorCode(string value)
        {
            return new ProvisioningErrorCode(value);
        }

        /// <summary>Implicit operator to convert ProvisioningErrorCode to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ProvisioningErrorCode" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ProvisioningErrorCode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode e1, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ProvisioningErrorCode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode e1, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ProvisioningErrorCode e2)
        {
            return e2.Equals(e1);
        }
    }
}