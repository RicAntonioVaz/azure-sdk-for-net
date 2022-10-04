// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class GeoRegionCollection
    {
        internal static GeoRegionCollection DeserializeGeoRegionCollection(JsonElement element)
        {
            IReadOnlyList<AppServiceGeoRegion> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AppServiceGeoRegion> array = new List<AppServiceGeoRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceGeoRegion.DeserializeAppServiceGeoRegion(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GeoRegionCollection(value, nextLink.Value);
        }
    }
}
