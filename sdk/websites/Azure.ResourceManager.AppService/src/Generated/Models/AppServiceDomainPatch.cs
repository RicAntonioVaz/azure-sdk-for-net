// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> ARM resource for a domain. </summary>
    public partial class AppServiceDomainPatch : ResourceData
    {
        /// <summary> Initializes a new instance of AppServiceDomainPatch. </summary>
        public AppServiceDomainPatch()
        {
            NameServers = new ChangeTrackingList<string>();
            ManagedHostNames = new ChangeTrackingList<AppServiceHostName>();
            DomainNotRenewableReasons = new ChangeTrackingList<DomainNotRenewableReason>();
        }

        /// <summary> Initializes a new instance of AppServiceDomainPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="contactAdmin"> Administrative contact. </param>
        /// <param name="contactBilling"> Billing contact. </param>
        /// <param name="contactRegistrant"> Registrant contact. </param>
        /// <param name="contactTech"> Technical contact. </param>
        /// <param name="registrationStatus"> Domain registration status. </param>
        /// <param name="provisioningState"> Domain provisioning state. </param>
        /// <param name="nameServers"> Name servers. </param>
        /// <param name="isDomainPrivacyEnabled"> &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="createdOn"> Domain creation timestamp. </param>
        /// <param name="expireOn"> Domain expiration timestamp. </param>
        /// <param name="lastRenewedOn"> Timestamp when the domain was renewed last time. </param>
        /// <param name="isAutoRenew"> &lt;code&gt;true&lt;/code&gt; if the domain should be automatically renewed; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isReadyForDnsRecordManagement">
        /// &lt;code&gt;true&lt;/code&gt; if Azure can assign this domain to App Service apps; otherwise, &lt;code&gt;false&lt;/code&gt;. This value will be &lt;code&gt;true&lt;/code&gt; if domain registration status is active and 
        ///  it is hosted on name servers Azure has programmatic access to.
        /// </param>
        /// <param name="managedHostNames"> All hostnames derived from the domain and assigned to Azure resources. </param>
        /// <param name="consent"> Legal agreement consent. </param>
        /// <param name="domainNotRenewableReasons"> Reasons why domain is not renewable. </param>
        /// <param name="dnsType"> Current DNS type. </param>
        /// <param name="dnsZoneId"> Azure DNS Zone to use. </param>
        /// <param name="targetDnsType"> Target DNS type (would be used for migration). </param>
        /// <param name="authCode"></param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppServiceDomainPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RegistrationContactInfo contactAdmin, RegistrationContactInfo contactBilling, RegistrationContactInfo contactRegistrant, RegistrationContactInfo contactTech, AppServiceDomainStatus? registrationStatus, ProvisioningState? provisioningState, IReadOnlyList<string> nameServers, bool? isDomainPrivacyEnabled, DateTimeOffset? createdOn, DateTimeOffset? expireOn, DateTimeOffset? lastRenewedOn, bool? isAutoRenew, bool? isReadyForDnsRecordManagement, IReadOnlyList<AppServiceHostName> managedHostNames, DomainPurchaseConsent consent, IReadOnlyList<DomainNotRenewableReason> domainNotRenewableReasons, AppServiceDnsType? dnsType, string dnsZoneId, AppServiceDnsType? targetDnsType, string authCode, string kind) : base(id, name, resourceType, systemData)
        {
            ContactAdmin = contactAdmin;
            ContactBilling = contactBilling;
            ContactRegistrant = contactRegistrant;
            ContactTech = contactTech;
            RegistrationStatus = registrationStatus;
            ProvisioningState = provisioningState;
            NameServers = nameServers;
            IsDomainPrivacyEnabled = isDomainPrivacyEnabled;
            CreatedOn = createdOn;
            ExpireOn = expireOn;
            LastRenewedOn = lastRenewedOn;
            IsAutoRenew = isAutoRenew;
            IsReadyForDnsRecordManagement = isReadyForDnsRecordManagement;
            ManagedHostNames = managedHostNames;
            Consent = consent;
            DomainNotRenewableReasons = domainNotRenewableReasons;
            DnsType = dnsType;
            DnsZoneId = dnsZoneId;
            TargetDnsType = targetDnsType;
            AuthCode = authCode;
            Kind = kind;
        }

        /// <summary> Administrative contact. </summary>
        public RegistrationContactInfo ContactAdmin { get; set; }
        /// <summary> Billing contact. </summary>
        public RegistrationContactInfo ContactBilling { get; set; }
        /// <summary> Registrant contact. </summary>
        public RegistrationContactInfo ContactRegistrant { get; set; }
        /// <summary> Technical contact. </summary>
        public RegistrationContactInfo ContactTech { get; set; }
        /// <summary> Domain registration status. </summary>
        public AppServiceDomainStatus? RegistrationStatus { get; }
        /// <summary> Domain provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Name servers. </summary>
        public IReadOnlyList<string> NameServers { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDomainPrivacyEnabled { get; set; }
        /// <summary> Domain creation timestamp. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Domain expiration timestamp. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Timestamp when the domain was renewed last time. </summary>
        public DateTimeOffset? LastRenewedOn { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the domain should be automatically renewed; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsAutoRenew { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if Azure can assign this domain to App Service apps; otherwise, &lt;code&gt;false&lt;/code&gt;. This value will be &lt;code&gt;true&lt;/code&gt; if domain registration status is active and 
        ///  it is hosted on name servers Azure has programmatic access to.
        /// </summary>
        public bool? IsReadyForDnsRecordManagement { get; }
        /// <summary> All hostnames derived from the domain and assigned to Azure resources. </summary>
        public IReadOnlyList<AppServiceHostName> ManagedHostNames { get; }
        /// <summary> Legal agreement consent. </summary>
        public DomainPurchaseConsent Consent { get; set; }
        /// <summary> Reasons why domain is not renewable. </summary>
        public IReadOnlyList<DomainNotRenewableReason> DomainNotRenewableReasons { get; }
        /// <summary> Current DNS type. </summary>
        public AppServiceDnsType? DnsType { get; set; }
        /// <summary> Azure DNS Zone to use. </summary>
        public string DnsZoneId { get; set; }
        /// <summary> Target DNS type (would be used for migration). </summary>
        public AppServiceDnsType? TargetDnsType { get; set; }
        /// <summary> Gets or sets the auth code. </summary>
        public string AuthCode { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
