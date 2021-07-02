// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The OSFamilyListResult. </summary>
    internal partial class OSFamilyListResult
    {
        /// <summary> Initializes a new instance of OSFamilyListResult. </summary>
        /// <param name="value"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal OSFamilyListResult(IEnumerable<OSFamily> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of OSFamilyListResult. </summary>
        /// <param name="value"> . </param>
        /// <param name="nextLink"> . </param>
        internal OSFamilyListResult(IReadOnlyList<OSFamily> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        public IReadOnlyList<OSFamily> Value { get; }
        public string NextLink { get; }
    }
}
