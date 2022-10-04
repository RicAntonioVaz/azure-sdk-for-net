// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the recovery plan shutdown group task details. </summary>
    public partial class RecoveryPlanShutdownGroupTaskDetails : RecoveryPlanGroupTaskDetails
    {
        /// <summary> Initializes a new instance of RecoveryPlanShutdownGroupTaskDetails. </summary>
        internal RecoveryPlanShutdownGroupTaskDetails()
        {
            InstanceType = "RecoveryPlanShutdownGroupTaskDetails";
        }

        /// <summary> Initializes a new instance of RecoveryPlanShutdownGroupTaskDetails. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="childTasks"> The child tasks. </param>
        /// <param name="name"> The name. </param>
        /// <param name="groupId"> The group identifier. </param>
        /// <param name="rpGroupType"> The group type. </param>
        internal RecoveryPlanShutdownGroupTaskDetails(string instanceType, IReadOnlyList<ASRTask> childTasks, string name, string groupId, string rpGroupType) : base(instanceType, childTasks, name, groupId, rpGroupType)
        {
            InstanceType = instanceType ?? "RecoveryPlanShutdownGroupTaskDetails";
        }
    }
}
