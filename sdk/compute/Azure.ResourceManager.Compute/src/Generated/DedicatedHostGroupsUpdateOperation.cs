// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> Update an dedicated host group. </summary>
    public partial class DedicatedHostGroupsUpdateOperation : Operation<DedicatedHostGroup>
    {
        private readonly OperationOrResponseInternals<DedicatedHostGroup> _operation;

        /// <summary> Initializes a new instance of DedicatedHostGroupsUpdateOperation for mocking. </summary>
        protected DedicatedHostGroupsUpdateOperation()
        {
        }

        internal DedicatedHostGroupsUpdateOperation(ResourceOperationsBase operationsBase, Response<DedicatedHostGroupData> response)
        {
            _operation = new OperationOrResponseInternals<DedicatedHostGroup>(Response.FromValue(new DedicatedHostGroup(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DedicatedHostGroup Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DedicatedHostGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DedicatedHostGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
