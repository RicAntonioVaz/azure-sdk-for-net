// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The CloudServiceListResult. </summary>
    internal partial class CloudServiceListResult
    {
        /// <summary> Initializes a new instance of CloudServiceListResult. </summary>
        /// <param name="value"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal CloudServiceListResult(IEnumerable<CloudServiceData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of CloudServiceListResult. </summary>
        /// <param name="value"> . </param>
        /// <param name="nextLink"> . </param>
        internal CloudServiceListResult(IReadOnlyList<CloudServiceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        public IReadOnlyList<CloudServiceData> Value { get; }
        public string NextLink { get; }
    }
}
