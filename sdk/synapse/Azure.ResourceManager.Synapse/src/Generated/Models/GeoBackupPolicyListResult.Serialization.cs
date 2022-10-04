// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class GeoBackupPolicyListResult
    {
        internal static GeoBackupPolicyListResult DeserializeGeoBackupPolicyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<GeoBackupPolicyData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GeoBackupPolicyData> array = new List<GeoBackupPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoBackupPolicyData.DeserializeGeoBackupPolicyData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new GeoBackupPolicyListResult(Optional.ToList(value));
        }
    }
}
