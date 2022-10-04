// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the properties for generating an MPEG-2 Transport Stream (ISO/IEC 13818-1) output video file(s). </summary>
    public partial class TransportStreamFormat : MultiBitrateFormat
    {
        /// <summary> Initializes a new instance of TransportStreamFormat. </summary>
        /// <param name="filenamePattern"> The pattern of the file names for the generated output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {Bitrate} - The audio/video bitrate. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filenamePattern"/> is null. </exception>
        public TransportStreamFormat(string filenamePattern) : base(filenamePattern)
        {
            if (filenamePattern == null)
            {
                throw new ArgumentNullException(nameof(filenamePattern));
            }

            OdataType = "#Microsoft.Media.TransportStreamFormat";
        }

        /// <summary> Initializes a new instance of TransportStreamFormat. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="filenamePattern"> The pattern of the file names for the generated output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {Bitrate} - The audio/video bitrate. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </param>
        /// <param name="outputFiles"> The list of output files to produce.  Each entry in the list is a set of audio and video layer labels to be muxed together . </param>
        internal TransportStreamFormat(string odataType, string filenamePattern, IList<MediaOutputFile> outputFiles) : base(odataType, filenamePattern, outputFiles)
        {
            OdataType = odataType ?? "#Microsoft.Media.TransportStreamFormat";
        }
    }
}
