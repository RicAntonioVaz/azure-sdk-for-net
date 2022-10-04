// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The response properties returned for a pipeline run. </summary>
    public partial class PipelineRunResult
    {
        /// <summary> Initializes a new instance of PipelineRunResult. </summary>
        internal PipelineRunResult()
        {
            ImportedArtifacts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PipelineRunResult. </summary>
        /// <param name="status"> The current status of the pipeline run. </param>
        /// <param name="importedArtifacts"> The artifacts imported in the pipeline run. </param>
        /// <param name="progress"> The current progress of the copy operation. </param>
        /// <param name="startOn"> The time the pipeline run started. </param>
        /// <param name="finishOn"> The time the pipeline run finished. </param>
        /// <param name="source"> The source of the pipeline run. </param>
        /// <param name="target"> The target of the pipeline run. </param>
        /// <param name="catalogDigest"> The digest of the tar used to transfer the artifacts. </param>
        /// <param name="trigger"> The trigger that caused the pipeline run. </param>
        /// <param name="pipelineRunErrorMessage"> The detailed error message for the pipeline run in the case of failure. </param>
        internal PipelineRunResult(string status, IReadOnlyList<string> importedArtifacts, PipelineProgress progress, DateTimeOffset? startOn, DateTimeOffset? finishOn, ImportPipelineSourceProperties source, ExportPipelineTargetProperties target, string catalogDigest, PipelineTriggerDescriptor trigger, string pipelineRunErrorMessage)
        {
            Status = status;
            ImportedArtifacts = importedArtifacts;
            Progress = progress;
            StartOn = startOn;
            FinishOn = finishOn;
            Source = source;
            Target = target;
            CatalogDigest = catalogDigest;
            Trigger = trigger;
            PipelineRunErrorMessage = pipelineRunErrorMessage;
        }

        /// <summary> The current status of the pipeline run. </summary>
        public string Status { get; }
        /// <summary> The artifacts imported in the pipeline run. </summary>
        public IReadOnlyList<string> ImportedArtifacts { get; }
        /// <summary> The current progress of the copy operation. </summary>
        internal PipelineProgress Progress { get; }
        /// <summary> The percentage complete of the copy operation. </summary>
        public string ProgressPercentage
        {
            get => Progress?.Percentage;
        }

        /// <summary> The time the pipeline run started. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The time the pipeline run finished. </summary>
        public DateTimeOffset? FinishOn { get; }
        /// <summary> The source of the pipeline run. </summary>
        public ImportPipelineSourceProperties Source { get; }
        /// <summary> The target of the pipeline run. </summary>
        public ExportPipelineTargetProperties Target { get; }
        /// <summary> The digest of the tar used to transfer the artifacts. </summary>
        public string CatalogDigest { get; }
        /// <summary> The trigger that caused the pipeline run. </summary>
        internal PipelineTriggerDescriptor Trigger { get; }
        /// <summary> The timestamp when the source update happened. </summary>
        public DateTimeOffset? SourceTriggerTimestamp
        {
            get => Trigger?.SourceTriggerTimestamp;
        }

        /// <summary> The detailed error message for the pipeline run in the case of failure. </summary>
        public string PipelineRunErrorMessage { get; }
    }
}
