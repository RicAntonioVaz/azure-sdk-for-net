// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Collection of all trigger on the data box edge device. </summary>
    internal partial class TriggerList
    {
        /// <summary> Initializes a new instance of TriggerList. </summary>
        internal TriggerList()
        {
            Value = new ChangeTrackingList<DataBoxEdgeTriggerData>();
        }

        /// <summary> Initializes a new instance of TriggerList. </summary>
        /// <param name="value">
        /// The list of triggers.
        /// Please note <see cref="DataBoxEdgeTriggerData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EdgeFileEventTrigger"/> and <see cref="PeriodicTimerEventTrigger"/>.
        /// </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal TriggerList(IReadOnlyList<DataBoxEdgeTriggerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The list of triggers.
        /// Please note <see cref="DataBoxEdgeTriggerData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EdgeFileEventTrigger"/> and <see cref="PeriodicTimerEventTrigger"/>.
        /// </summary>
        public IReadOnlyList<DataBoxEdgeTriggerData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
