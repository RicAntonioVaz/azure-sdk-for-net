// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Custom setup script properties for a managed dedicated integration runtime. </summary>
    public partial class IntegrationRuntimeCustomSetupScriptProperties
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeCustomSetupScriptProperties. </summary>
        public IntegrationRuntimeCustomSetupScriptProperties()
        {
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeCustomSetupScriptProperties. </summary>
        /// <param name="blobContainerUri"> The URI of the Azure blob container that contains the custom setup script. </param>
        /// <param name="sasToken"> The SAS token of the Azure blob container. </param>
        internal IntegrationRuntimeCustomSetupScriptProperties(Uri blobContainerUri, SecureString sasToken)
        {
            BlobContainerUri = blobContainerUri;
            SasToken = sasToken;
        }

        /// <summary> The URI of the Azure blob container that contains the custom setup script. </summary>
        public Uri BlobContainerUri { get; set; }
        /// <summary> The SAS token of the Azure blob container. </summary>
        public SecureString SasToken { get; set; }
    }
}
