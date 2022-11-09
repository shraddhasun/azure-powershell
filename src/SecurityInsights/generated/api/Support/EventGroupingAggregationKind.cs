// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support
{

    /// <summary>The event grouping aggregation kinds</summary>
    public partial struct EventGroupingAggregationKind :
        System.IEquatable<EventGroupingAggregationKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EventGroupingAggregationKind AlertPerResult = @"AlertPerResult";

        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EventGroupingAggregationKind SingleAlert = @"SingleAlert";

        /// <summary>
        /// the value for an instance of the <see cref="EventGroupingAggregationKind" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to EventGroupingAggregationKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EventGroupingAggregationKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new EventGroupingAggregationKind(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type EventGroupingAggregationKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EventGroupingAggregationKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type EventGroupingAggregationKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is EventGroupingAggregationKind && Equals((EventGroupingAggregationKind)obj);
        }

        /// <summary>
        /// Creates an instance of the <see cref="EventGroupingAggregationKind"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private EventGroupingAggregationKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum EventGroupingAggregationKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for EventGroupingAggregationKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to EventGroupingAggregationKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EventGroupingAggregationKind" />.</param>

        public static implicit operator EventGroupingAggregationKind(string value)
        {
            return new EventGroupingAggregationKind(value);
        }

        /// <summary>Implicit operator to convert EventGroupingAggregationKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="EventGroupingAggregationKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EventGroupingAggregationKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum EventGroupingAggregationKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EventGroupingAggregationKind e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EventGroupingAggregationKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum EventGroupingAggregationKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EventGroupingAggregationKind e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EventGroupingAggregationKind e2)
        {
            return e2.Equals(e1);
        }
    }
}