// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedNetwork
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _managedNetworkClientDiagnostics;
        private ManagedNetworksRestOperations _managedNetworkRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ManagedNetworkClientDiagnostics => _managedNetworkClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ManagedNetwork", ManagedNetworkResource.ResourceType.Namespace, Diagnostics);
        private ManagedNetworksRestOperations ManagedNetworkRestClient => _managedNetworkRestClient ??= new ManagedNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ManagedNetworkResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// The ListBySubscription  ManagedNetwork operation retrieves all the Managed Network Resources in the current subscription in a paginated format.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetwork/managedNetworks
        /// Operation Id: ManagedNetworks_ListBySubscription
        /// </summary>
        /// <param name="top"> May be used to limit the number of results in a page for list queries. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedNetworkResource> GetManagedNetworksAsync(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedNetworkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedNetworkClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedNetworks");
                scope.Start();
                try
                {
                    var response = await ManagedNetworkRestClient.ListBySubscriptionAsync(Id.SubscriptionId, top, skiptoken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedNetworkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedNetworkResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedNetworkClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedNetworks");
                scope.Start();
                try
                {
                    var response = await ManagedNetworkRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, top, skiptoken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedNetworkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// The ListBySubscription  ManagedNetwork operation retrieves all the Managed Network Resources in the current subscription in a paginated format.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetwork/managedNetworks
        /// Operation Id: ManagedNetworks_ListBySubscription
        /// </summary>
        /// <param name="top"> May be used to limit the number of results in a page for list queries. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedNetworkResource> GetManagedNetworks(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedNetworkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedNetworkClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedNetworks");
                scope.Start();
                try
                {
                    var response = ManagedNetworkRestClient.ListBySubscription(Id.SubscriptionId, top, skiptoken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedNetworkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedNetworkResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedNetworkClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedNetworks");
                scope.Start();
                try
                {
                    var response = ManagedNetworkRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, top, skiptoken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedNetworkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
