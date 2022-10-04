// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Client script details for file / folder restore. </summary>
    public partial class ClientScriptForConnect
    {
        /// <summary> Initializes a new instance of ClientScriptForConnect. </summary>
        internal ClientScriptForConnect()
        {
        }

        /// <summary> Initializes a new instance of ClientScriptForConnect. </summary>
        /// <param name="scriptContent"> File content of the client script for file / folder restore. </param>
        /// <param name="scriptExtension"> File extension of the client script for file / folder restore - .ps1 , .sh , etc. </param>
        /// <param name="osType"> OS type - Windows, Linux etc. for which this file / folder restore client script works. </param>
        /// <param name="uri"> URL of Executable from where to source the content. If this is not null then ScriptContent should not be used. </param>
        /// <param name="scriptNameSuffix">
        /// Mandatory suffix that should be added to the name of script that is given for download to user.
        /// If its null or empty then , ignore it.
        /// </param>
        internal ClientScriptForConnect(string scriptContent, string scriptExtension, string osType, Uri uri, string scriptNameSuffix)
        {
            ScriptContent = scriptContent;
            ScriptExtension = scriptExtension;
            OSType = osType;
            Uri = uri;
            ScriptNameSuffix = scriptNameSuffix;
        }

        /// <summary> File content of the client script for file / folder restore. </summary>
        public string ScriptContent { get; }
        /// <summary> File extension of the client script for file / folder restore - .ps1 , .sh , etc. </summary>
        public string ScriptExtension { get; }
        /// <summary> OS type - Windows, Linux etc. for which this file / folder restore client script works. </summary>
        public string OSType { get; }
        /// <summary> URL of Executable from where to source the content. If this is not null then ScriptContent should not be used. </summary>
        public Uri Uri { get; }
        /// <summary>
        /// Mandatory suffix that should be added to the name of script that is given for download to user.
        /// If its null or empty then , ignore it.
        /// </summary>
        public string ScriptNameSuffix { get; }
    }
}
