// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Create network mappings input. </summary>
    public partial class NetworkMappingCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of NetworkMappingCreateOrUpdateContent. </summary>
        /// <param name="properties"> Input properties for creating network mapping. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public NetworkMappingCreateOrUpdateContent(CreateNetworkMappingInputProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Input properties for creating network mapping. </summary>
        public CreateNetworkMappingInputProperties Properties { get; }
    }
}
