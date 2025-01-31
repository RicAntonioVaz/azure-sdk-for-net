// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ShareInfoElement
    {
        internal static ShareInfoElement DeserializeShareInfoElement(JsonElement element)
        {
            Optional<Uri> vmUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        vmUri = null;
                        continue;
                    }
                    vmUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ShareInfoElement(vmUri.Value);
        }
    }
}
