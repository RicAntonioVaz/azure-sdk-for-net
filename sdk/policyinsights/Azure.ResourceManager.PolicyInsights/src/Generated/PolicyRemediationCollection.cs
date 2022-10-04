// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="PolicyRemediationResource" /> and their operations.
    /// Each <see cref="PolicyRemediationResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="PolicyRemediationCollection" /> instance call the GetPolicyRemediations method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class PolicyRemediationCollection : ArmCollection, IEnumerable<PolicyRemediationResource>, IAsyncEnumerable<PolicyRemediationResource>
    {
        private readonly ClientDiagnostics _policyRemediationRemediationsClientDiagnostics;
        private readonly RemediationsRestOperations _policyRemediationRemediationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PolicyRemediationCollection"/> class for mocking. </summary>
        protected PolicyRemediationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyRemediationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PolicyRemediationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyRemediationRemediationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", PolicyRemediationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PolicyRemediationResource.ResourceType, out string policyRemediationRemediationsApiVersion);
            _policyRemediationRemediationsRestClient = new RemediationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyRemediationRemediationsApiVersion);
        }

        /// <summary>
        /// Creates or updates a remediation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_CreateOrUpdateAtResource
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="data"> The remediation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicyRemediationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string remediationName, PolicyRemediationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _policyRemediationRemediationsRestClient.CreateOrUpdateAtResourceAsync(Id, remediationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation<PolicyRemediationResource>(Response.FromValue(new PolicyRemediationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a remediation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_CreateOrUpdateAtResource
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="data"> The remediation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PolicyRemediationResource> CreateOrUpdate(WaitUntil waitUntil, string remediationName, PolicyRemediationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _policyRemediationRemediationsRestClient.CreateOrUpdateAtResource(Id, remediationName, data, cancellationToken);
                var operation = new PolicyInsightsArmOperation<PolicyRemediationResource>(Response.FromValue(new PolicyRemediationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing remediation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_GetAtResource
        /// </summary>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        public virtual async Task<Response<PolicyRemediationResource>> GetAsync(string remediationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));

            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyRemediationRemediationsRestClient.GetAtResourceAsync(Id, remediationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyRemediationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing remediation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_GetAtResource
        /// </summary>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        public virtual Response<PolicyRemediationResource> Get(string remediationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));

            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.Get");
            scope.Start();
            try
            {
                var response = _policyRemediationRemediationsRestClient.GetAtResource(Id, remediationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyRemediationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all remediations for a resource.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForResource
        /// </summary>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyRemediationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyRemediationResource> GetAllAsync(PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyRemediationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyRemediationRemediationsRestClient.ListForResourceAsync(Id, policyQuerySettings, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyRemediationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyRemediationRemediationsRestClient.ListForResourceNextPageAsync(nextLink, Id, policyQuerySettings, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all remediations for a resource.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForResource
        /// </summary>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyRemediationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyRemediationResource> GetAll(PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyRemediationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyRemediationRemediationsRestClient.ListForResource(Id, policyQuerySettings, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyRemediationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyRemediationRemediationsRestClient.ListForResourceNextPage(nextLink, Id, policyQuerySettings, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_GetAtResource
        /// </summary>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string remediationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));

            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _policyRemediationRemediationsRestClient.GetAtResourceAsync(Id, remediationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_GetAtResource
        /// </summary>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        public virtual Response<bool> Exists(string remediationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));

            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationCollection.Exists");
            scope.Start();
            try
            {
                var response = _policyRemediationRemediationsRestClient.GetAtResource(Id, remediationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PolicyRemediationResource> IEnumerable<PolicyRemediationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PolicyRemediationResource> IAsyncEnumerable<PolicyRemediationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
