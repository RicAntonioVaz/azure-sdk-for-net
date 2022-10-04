// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disk input details. </summary>
    public partial class InMageAzureV2DiskInputDetails
    {
        /// <summary> Initializes a new instance of InMageAzureV2DiskInputDetails. </summary>
        public InMageAzureV2DiskInputDetails()
        {
        }

        /// <summary> The DiskId. </summary>
        public string DiskId { get; set; }
        /// <summary> The LogStorageAccountId. </summary>
        public string LogStorageAccountId { get; set; }
        /// <summary> The DiskType. </summary>
        public DiskAccountType? DiskType { get; set; }
        /// <summary> The DiskEncryptionSet ARM ID. </summary>
        public string DiskEncryptionSetId { get; set; }
    }
}
