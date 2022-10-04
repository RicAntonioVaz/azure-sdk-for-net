// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a PrivateLinkHubPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PrivateLinkHubPrivateLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPrivateLinkHubPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="PrivateLinkHubResource" /> using the GetPrivateLinkHubPrivateLinkResource method.
    /// </summary>
    public partial class PrivateLinkHubPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PrivateLinkHubPrivateLinkResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string privateLinkHubName, string privateLinkResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateLinkResources/{privateLinkResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateLinkHubPrivateLinkResourceClientDiagnostics;
        private readonly PrivateLinkHubPrivateLinkResourcesRestOperations _privateLinkHubPrivateLinkResourceRestClient;
        private readonly SynapsePrivateLinkResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkHubPrivateLinkResource"/> class for mocking. </summary>
        protected PrivateLinkHubPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateLinkHubPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PrivateLinkHubPrivateLinkResource(ArmClient client, SynapsePrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkHubPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateLinkHubPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateLinkHubPrivateLinkResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string privateLinkHubPrivateLinkResourceApiVersion);
            _privateLinkHubPrivateLinkResourceRestClient = new PrivateLinkHubPrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateLinkHubPrivateLinkResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/privateLinkHubs/privateLinkResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapsePrivateLinkResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get private link resource in private link hub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkHubPrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateLinkHubPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateLinkHubPrivateLinkResourceClientDiagnostics.CreateScope("PrivateLinkHubPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _privateLinkHubPrivateLinkResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkHubPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get private link resource in private link hub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkHubPrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateLinkHubPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _privateLinkHubPrivateLinkResourceClientDiagnostics.CreateScope("PrivateLinkHubPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _privateLinkHubPrivateLinkResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkHubPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
