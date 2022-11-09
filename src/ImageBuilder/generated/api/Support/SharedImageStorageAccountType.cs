// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support
{

    /// <summary>
    /// Storage account type to be used to store the shared image. Omit to use the default (Standard_LRS).
    /// </summary>
    public partial struct SharedImageStorageAccountType :
        System.IEquatable<SharedImageStorageAccountType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.SharedImageStorageAccountType StandardLrs = @"Standard_LRS";

        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.SharedImageStorageAccountType StandardZrs = @"Standard_ZRS";

        /// <summary>
        /// the value for an instance of the <see cref="SharedImageStorageAccountType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SharedImageStorageAccountType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SharedImageStorageAccountType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SharedImageStorageAccountType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SharedImageStorageAccountType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.SharedImageStorageAccountType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type SharedImageStorageAccountType (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SharedImageStorageAccountType && Equals((SharedImageStorageAccountType)obj);
        }

        /// <summary>Returns hashCode for enum SharedImageStorageAccountType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="SharedImageStorageAccountType"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SharedImageStorageAccountType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SharedImageStorageAccountType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SharedImageStorageAccountType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SharedImageStorageAccountType" />.</param>

        public static implicit operator SharedImageStorageAccountType(string value)
        {
            return new SharedImageStorageAccountType(value);
        }

        /// <summary>Implicit operator to convert SharedImageStorageAccountType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SharedImageStorageAccountType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.SharedImageStorageAccountType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SharedImageStorageAccountType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.SharedImageStorageAccountType e1, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.SharedImageStorageAccountType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SharedImageStorageAccountType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.SharedImageStorageAccountType e1, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.SharedImageStorageAccountType e2)
        {
            return e2.Equals(e1);
        }
    }
}