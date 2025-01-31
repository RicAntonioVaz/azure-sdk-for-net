// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary> A class representing the ManagedClusterSnapshot data model. </summary>
    public partial class ManagedClusterSnapshotData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ManagedClusterSnapshotData. </summary>
        /// <param name="location"> The location. </param>
        public ManagedClusterSnapshotData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterSnapshotData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="creationData"> CreationData to be used to specify the source resource ID to create this snapshot. </param>
        /// <param name="snapshotType"> The type of a snapshot. The default is NodePool. </param>
        /// <param name="managedClusterPropertiesReadOnly"> What the properties will be showed when getting managed cluster snapshot. Those properties are read-only. </param>
        internal ManagedClusterSnapshotData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ContainerServiceCreationData creationData, SnapshotType? snapshotType, ManagedClusterPropertiesForSnapshot managedClusterPropertiesReadOnly) : base(id, name, resourceType, systemData, tags, location)
        {
            CreationData = creationData;
            SnapshotType = snapshotType;
            ManagedClusterPropertiesReadOnly = managedClusterPropertiesReadOnly;
        }

        /// <summary> CreationData to be used to specify the source resource ID to create this snapshot. </summary>
        internal ContainerServiceCreationData CreationData { get; set; }
        /// <summary> This is the ARM ID of the source object to be used to create the target object. </summary>
        public ResourceIdentifier CreationDataSourceResourceId
        {
            get => CreationData is null ? default : CreationData.SourceResourceId;
            set
            {
                if (CreationData is null)
                    CreationData = new ContainerServiceCreationData();
                CreationData.SourceResourceId = value;
            }
        }

        /// <summary> The type of a snapshot. The default is NodePool. </summary>
        public SnapshotType? SnapshotType { get; set; }
        /// <summary> What the properties will be showed when getting managed cluster snapshot. Those properties are read-only. </summary>
        public ManagedClusterPropertiesForSnapshot ManagedClusterPropertiesReadOnly { get; }
    }
}
