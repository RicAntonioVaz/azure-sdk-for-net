// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The top level Log Analytics cluster resource container. </summary>
    public partial class ClusterPatch
    {
        /// <summary> Initializes a new instance of ClusterPatch. </summary>
        public ClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The sku properties. </summary>
        public ClusterSku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The associated key properties. </summary>
        public KeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> The cluster&apos;s billing type. </summary>
        public BillingType? BillingType { get; set; }
    }
}
