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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecureScoreItem along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SecureScoreItemResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSecureScoreItemResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetSecureScoreItem method.
    /// </summary>
    public partial class SecureScoreItemResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecureScoreItemResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string secureScoreName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _secureScoreItemSecureScoresClientDiagnostics;
        private readonly SecureScoresRestOperations _secureScoreItemSecureScoresRestClient;
        private readonly ClientDiagnostics _secureScoreControlsClientDiagnostics;
        private readonly SecureScoreControlsRestOperations _secureScoreControlsRestClient;
        private readonly SecureScoreItemData _data;

        /// <summary> Initializes a new instance of the <see cref="SecureScoreItemResource"/> class for mocking. </summary>
        protected SecureScoreItemResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SecureScoreItemResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecureScoreItemResource(ArmClient client, SecureScoreItemData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecureScoreItemResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecureScoreItemResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _secureScoreItemSecureScoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string secureScoreItemSecureScoresApiVersion);
            _secureScoreItemSecureScoresRestClient = new SecureScoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, secureScoreItemSecureScoresApiVersion);
            _secureScoreControlsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _secureScoreControlsRestClient = new SecureScoreControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/secureScores";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecureScoreItemData Data
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
        /// Get secure score for a specific Microsoft Defender for Cloud initiative within your current scope. For the ASC Default initiative, use &apos;ascScore&apos;.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}
        /// Operation Id: SecureScores_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecureScoreItemResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _secureScoreItemSecureScoresClientDiagnostics.CreateScope("SecureScoreItemResource.Get");
            scope.Start();
            try
            {
                var response = await _secureScoreItemSecureScoresRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecureScoreItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get secure score for a specific Microsoft Defender for Cloud initiative within your current scope. For the ASC Default initiative, use &apos;ascScore&apos;.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}
        /// Operation Id: SecureScores_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecureScoreItemResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _secureScoreItemSecureScoresClientDiagnostics.CreateScope("SecureScoreItemResource.Get");
            scope.Start();
            try
            {
                var response = _secureScoreItemSecureScoresRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecureScoreItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all security controls for a specific initiative within a scope
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}/secureScoreControls
        /// Operation Id: SecureScoreControls_ListBySecureScore
        /// </summary>
        /// <param name="expand"> OData expand. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecureScoreControlDetails" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecureScoreControlDetails> GetSecureScoreControlsAsync(ExpandControlsEnum? expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SecureScoreControlDetails>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _secureScoreControlsClientDiagnostics.CreateScope("SecureScoreItemResource.GetSecureScoreControls");
                scope.Start();
                try
                {
                    var response = await _secureScoreControlsRestClient.ListBySecureScoreAsync(Id.SubscriptionId, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SecureScoreControlDetails>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _secureScoreControlsClientDiagnostics.CreateScope("SecureScoreItemResource.GetSecureScoreControls");
                scope.Start();
                try
                {
                    var response = await _secureScoreControlsRestClient.ListBySecureScoreNextPageAsync(nextLink, Id.SubscriptionId, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Get all security controls for a specific initiative within a scope
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}/secureScoreControls
        /// Operation Id: SecureScoreControls_ListBySecureScore
        /// </summary>
        /// <param name="expand"> OData expand. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecureScoreControlDetails" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecureScoreControlDetails> GetSecureScoreControls(ExpandControlsEnum? expand = null, CancellationToken cancellationToken = default)
        {
            Page<SecureScoreControlDetails> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _secureScoreControlsClientDiagnostics.CreateScope("SecureScoreItemResource.GetSecureScoreControls");
                scope.Start();
                try
                {
                    var response = _secureScoreControlsRestClient.ListBySecureScore(Id.SubscriptionId, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SecureScoreControlDetails> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _secureScoreControlsClientDiagnostics.CreateScope("SecureScoreItemResource.GetSecureScoreControls");
                scope.Start();
                try
                {
                    var response = _secureScoreControlsRestClient.ListBySecureScoreNextPage(nextLink, Id.SubscriptionId, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
