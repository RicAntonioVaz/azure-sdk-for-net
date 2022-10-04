// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesIPConfiguration
    {
        internal static EdgeKubernetesIPConfiguration DeserializeEdgeKubernetesIPConfiguration(JsonElement element)
        {
            Optional<string> port = default;
            Optional<string> ipAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("port"))
                {
                    port = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
            }
            return new EdgeKubernetesIPConfiguration(port.Value, ipAddress.Value);
        }
    }
}
