// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DNS settings of a network interface.
    /// </summary>
    public partial class NetworkInterfaceDnsSettings
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceDnsSettings
        /// class.
        /// </summary>
        public NetworkInterfaceDnsSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceDnsSettings
        /// class.
        /// </summary>
        /// <param name="dnsServers">List of DNS servers IP addresses. Use
        /// 'AzureProvidedDNS' to switch to azure provided DNS resolution.
        /// 'AzureProvidedDNS' value cannot be combined with other IPs, it must
        /// be the only value in dnsServers collection.</param>
        /// <param name="appliedDnsServers">If the VM that uses this NIC is
        /// part of an Availability Set, then this list will have the union of
        /// all DNS servers from all NICs that are part of the Availability
        /// Set. This property is what is configured on each of those
        /// VMs.</param>
        /// <param name="internalDnsNameLabel">Relative DNS name for this NIC
        /// used for internal communications between VMs in the same virtual
        /// network.</param>
        /// <param name="internalFqdn">Fully qualified DNS name supporting
        /// internal communications between VMs in the same virtual
        /// network.</param>
        /// <param name="internalDomainNameSuffix">Even if internalDnsNameLabel
        /// is not specified, a DNS entry is created for the primary NIC of the
        /// VM. This DNS name can be constructed by concatenating the VM name
        /// with the value of internalDomainNameSuffix.</param>
        public NetworkInterfaceDnsSettings(IList<string> dnsServers = default(IList<string>), IList<string> appliedDnsServers = default(IList<string>), string internalDnsNameLabel = default(string), string internalFqdn = default(string), string internalDomainNameSuffix = default(string))
        {
            DnsServers = dnsServers;
            AppliedDnsServers = appliedDnsServers;
            InternalDnsNameLabel = internalDnsNameLabel;
            InternalFqdn = internalFqdn;
            InternalDomainNameSuffix = internalDomainNameSuffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of DNS servers IP addresses. Use
        /// 'AzureProvidedDNS' to switch to azure provided DNS resolution.
        /// 'AzureProvidedDNS' value cannot be combined with other IPs, it must
        /// be the only value in dnsServers collection.
        /// </summary>
        [JsonProperty(PropertyName = "dnsServers")]
        public IList<string> DnsServers { get; set; }

        /// <summary>
        /// Gets if the VM that uses this NIC is part of an Availability Set,
        /// then this list will have the union of all DNS servers from all NICs
        /// that are part of the Availability Set. This property is what is
        /// configured on each of those VMs.
        /// </summary>
        [JsonProperty(PropertyName = "appliedDnsServers")]
        public IList<string> AppliedDnsServers { get; private set; }

        /// <summary>
        /// Gets or sets relative DNS name for this NIC used for internal
        /// communications between VMs in the same virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "internalDnsNameLabel")]
        public string InternalDnsNameLabel { get; set; }

        /// <summary>
        /// Gets fully qualified DNS name supporting internal communications
        /// between VMs in the same virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "internalFqdn")]
        public string InternalFqdn { get; private set; }

        /// <summary>
        /// Gets even if internalDnsNameLabel is not specified, a DNS entry is
        /// created for the primary NIC of the VM. This DNS name can be
        /// constructed by concatenating the VM name with the value of
        /// internalDomainNameSuffix.
        /// </summary>
        [JsonProperty(PropertyName = "internalDomainNameSuffix")]
        public string InternalDomainNameSuffix { get; private set; }

    }
}
