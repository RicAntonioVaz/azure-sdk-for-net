// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A collection of AssetFilter items. </summary>
    internal partial class MediaAssetFilterListResult
    {
        /// <summary> Initializes a new instance of MediaAssetFilterListResult. </summary>
        internal MediaAssetFilterListResult()
        {
            Value = new ChangeTrackingList<MediaAssetFilterData>();
        }

        /// <summary> Initializes a new instance of MediaAssetFilterListResult. </summary>
        /// <param name="value"> A collection of AssetFilter items. </param>
        /// <param name="odataNextLink"> A link to the next page of the collection (when the collection contains too many results to return in one response). </param>
        internal MediaAssetFilterListResult(IReadOnlyList<MediaAssetFilterData> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> A collection of AssetFilter items. </summary>
        public IReadOnlyList<MediaAssetFilterData> Value { get; }
        /// <summary> A link to the next page of the collection (when the collection contains too many results to return in one response). </summary>
        public string OdataNextLink { get; }
    }
}
