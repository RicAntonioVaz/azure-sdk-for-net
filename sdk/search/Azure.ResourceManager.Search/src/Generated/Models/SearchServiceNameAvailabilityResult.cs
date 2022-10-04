// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Output of check name availability API. </summary>
    public partial class SearchServiceNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of SearchServiceNameAvailabilityResult. </summary>
        internal SearchServiceNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of SearchServiceNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable"> A value indicating whether the name is available. </param>
        /// <param name="reason"> The reason why the name is not available. &apos;Invalid&apos; indicates the name provided does not match the naming requirements (incorrect length, unsupported characters, etc.). &apos;AlreadyExists&apos; indicates that the name is already in use and is therefore unavailable. </param>
        /// <param name="message"> A message that explains why the name is invalid and provides resource naming requirements. Available only if &apos;Invalid&apos; is returned in the &apos;reason&apos; property. </param>
        internal SearchServiceNameAvailabilityResult(bool? isNameAvailable, SearchServiceNameUnavailableReason? reason, string message)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> A value indicating whether the name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason why the name is not available. &apos;Invalid&apos; indicates the name provided does not match the naming requirements (incorrect length, unsupported characters, etc.). &apos;AlreadyExists&apos; indicates that the name is already in use and is therefore unavailable. </summary>
        public SearchServiceNameUnavailableReason? Reason { get; }
        /// <summary> A message that explains why the name is invalid and provides resource naming requirements. Available only if &apos;Invalid&apos; is returned in the &apos;reason&apos; property. </summary>
        public string Message { get; }
    }
}
