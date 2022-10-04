// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> List of ProtectedItem resources. </summary>
    internal partial class ProtectedItemResourceList
    {
        /// <summary> Initializes a new instance of ProtectedItemResourceList. </summary>
        internal ProtectedItemResourceList()
        {
            Value = new ChangeTrackingList<ProtectedItemResourceData>();
        }

        /// <summary> Initializes a new instance of ProtectedItemResourceList. </summary>
        /// <param name="value"> List of resources. </param>
        /// <param name="nextLink"> The uri to fetch the next page of resources. </param>
        internal ProtectedItemResourceList(IReadOnlyList<ProtectedItemResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of resources. </summary>
        public IReadOnlyList<ProtectedItemResourceData> Value { get; }
        /// <summary> The uri to fetch the next page of resources. </summary>
        public string NextLink { get; }
    }
}
