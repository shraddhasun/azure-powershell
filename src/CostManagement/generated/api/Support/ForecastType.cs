// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>The type of the forecast.</summary>
    public partial struct ForecastType :
        System.IEquatable<ForecastType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType ActualCost = @"ActualCost";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType AmortizedCost = @"AmortizedCost";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType Usage = @"Usage";

        /// <summary>the value for an instance of the <see cref="ForecastType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ForecastType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ForecastType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ForecastType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ForecastType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ForecastType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ForecastType && Equals((ForecastType)obj);
        }

        /// <summary>Creates an instance of the <see cref="ForecastType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ForecastType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum ForecastType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ForecastType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ForecastType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ForecastType" />.</param>

        public static implicit operator ForecastType(string value)
        {
            return new ForecastType(value);
        }

        /// <summary>Implicit operator to convert ForecastType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ForecastType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ForecastType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ForecastType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.ForecastType e2)
        {
            return e2.Equals(e1);
        }
    }
}