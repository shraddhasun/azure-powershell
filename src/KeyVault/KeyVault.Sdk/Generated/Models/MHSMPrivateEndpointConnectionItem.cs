// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Private endpoint connection item.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MHSMPrivateEndpointConnectionItem
    {
        /// <summary>
        /// Initializes a new instance of the MHSMPrivateEndpointConnectionItem
        /// class.
        /// </summary>
        public MHSMPrivateEndpointConnectionItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MHSMPrivateEndpointConnectionItem
        /// class.
        /// </summary>
        /// <param name="id">Id of private endpoint connection.</param>
        /// <param name="etag">Modified whenever there is a change in the state
        /// of private endpoint connection.</param>
        /// <param name="privateEndpoint">Properties of the private endpoint
        /// object.</param>
        /// <param name="privateLinkServiceConnectionState">Approval state of
        /// the private link connection.</param>
        /// <param name="provisioningState">Provisioning state of the private
        /// endpoint connection. Possible values include: 'Succeeded',
        /// 'Creating', 'Updating', 'Deleting', 'Failed',
        /// 'Disconnected'</param>
        public MHSMPrivateEndpointConnectionItem(string id = default(string), string etag = default(string), MHSMPrivateEndpoint privateEndpoint = default(MHSMPrivateEndpoint), MHSMPrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(MHSMPrivateLinkServiceConnectionState), string provisioningState = default(string))
        {
            Id = id;
            Etag = etag;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of private endpoint connection.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets modified whenever there is a change in the state of
        /// private endpoint connection.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets properties of the private endpoint object.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpoint")]
        public MHSMPrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Gets or sets approval state of the private link connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceConnectionState")]
        public MHSMPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the private endpoint connection.
        /// Possible values include: 'Succeeded', 'Creating', 'Updating',
        /// 'Deleting', 'Failed', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
