// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> List of all the resources being monitored by Dynatrace monitor resource. </summary>
    internal partial class MonitoredResourceListResponse
    {
        /// <summary> Initializes a new instance of MonitoredResourceListResponse. </summary>
        internal MonitoredResourceListResponse()
        {
            Value = new ChangeTrackingList<DynatraceMonitoredResourceDetails>();
        }

        /// <summary> Initializes a new instance of MonitoredResourceListResponse. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal MonitoredResourceListResponse(IReadOnlyList<DynatraceMonitoredResourceDetails> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on this page. </summary>
        public IReadOnlyList<DynatraceMonitoredResourceDetails> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
