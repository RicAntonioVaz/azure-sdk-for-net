// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The properties of the source resource that this restore point collection is created from. </summary>
    public partial class RestorePointCollectionSourceProperties : WritableSubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of RestorePointCollectionSourceProperties. </summary>
        public RestorePointCollectionSourceProperties()
        {
        }

        /// <summary> Initializes a new instance of RestorePointCollectionSourceProperties. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="location"> Location of the source resource used to create this restore point collection. </param>
        internal RestorePointCollectionSourceProperties(string id, string location) : base(id)
        {
            Location = location;
        }

        /// <summary> Location of the source resource used to create this restore point collection. </summary>
        public string Location { get; }
    }
}
