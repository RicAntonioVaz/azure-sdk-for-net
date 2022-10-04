// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary> The parameters used to create a new firewall rule while creating a new Data Lake Analytics account. </summary>
    public partial class CreateFirewallRuleWithAccountParameters
    {
        /// <summary> Initializes a new instance of CreateFirewallRuleWithAccountParameters. </summary>
        /// <param name="name"> The unique name of the firewall rule to create. </param>
        /// <param name="startIPAddress"> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <param name="endIPAddress"> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="startIPAddress"/> or <paramref name="endIPAddress"/> is null. </exception>
        public CreateFirewallRuleWithAccountParameters(string name, string startIPAddress, string endIPAddress)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (startIPAddress == null)
            {
                throw new ArgumentNullException(nameof(startIPAddress));
            }
            if (endIPAddress == null)
            {
                throw new ArgumentNullException(nameof(endIPAddress));
            }

            Name = name;
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> The unique name of the firewall rule to create. </summary>
        public string Name { get; }
        /// <summary> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </summary>
        public string StartIPAddress { get; }
        /// <summary> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </summary>
        public string EndIPAddress { get; }
    }
}
