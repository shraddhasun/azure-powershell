// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support
{

    /// <summary>The kind of the entity</summary>
    public partial struct EntityKind :
        System.IEquatable<EntityKind>
    {
        /// <summary>Entity represents account in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind Account = @"Account";

        /// <summary>Entity represents azure resource in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind AzureResource = @"AzureResource";

        /// <summary>Entity represents bookmark in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind Bookmark = @"Bookmark";

        /// <summary>Entity represents cloud application in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind CloudApplication = @"CloudApplication";

        /// <summary>Entity represents dns resolution in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind DnsResolution = @"DnsResolution";

        /// <summary>Entity represents file in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind File = @"File";

        /// <summary>Entity represents file hash in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind FileHash = @"FileHash";

        /// <summary>Entity represents host in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind Host = @"Host";

        /// <summary>Entity represents ip in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind IP = @"Ip";

        /// <summary>Entity represents IoT device in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind IoTDevice = @"IoTDevice";

        /// <summary>Entity represents mail cluster in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind MailCluster = @"MailCluster";

        /// <summary>Entity represents mail message in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind MailMessage = @"MailMessage";

        /// <summary>Entity represents mailbox in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind Mailbox = @"Mailbox";

        /// <summary>Entity represents malware in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind Malware = @"Malware";

        /// <summary>Entity represents process in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind Process = @"Process";

        /// <summary>Entity represents registry key in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind RegistryKey = @"RegistryKey";

        /// <summary>Entity represents registry value in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind RegistryValue = @"RegistryValue";

        /// <summary>Entity represents security alert in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind SecurityAlert = @"SecurityAlert";

        /// <summary>Entity represents security group in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind SecurityGroup = @"SecurityGroup";

        /// <summary>Entity represents submission mail in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind SubmissionMail = @"SubmissionMail";

        /// <summary>Entity represents url in the system.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind Url = @"Url";

        /// <summary>the value for an instance of the <see cref="EntityKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to EntityKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EntityKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new EntityKind(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="EntityKind"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private EntityKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type EntityKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type EntityKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is EntityKind && Equals((EntityKind)obj);
        }

        /// <summary>Returns hashCode for enum EntityKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for EntityKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to EntityKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EntityKind" />.</param>

        public static implicit operator EntityKind(string value)
        {
            return new EntityKind(value);
        }

        /// <summary>Implicit operator to convert EntityKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="EntityKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum EntityKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum EntityKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind e2)
        {
            return e2.Equals(e1);
        }
    }
}