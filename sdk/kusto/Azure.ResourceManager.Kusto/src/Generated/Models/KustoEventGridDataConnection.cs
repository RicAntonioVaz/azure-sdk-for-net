// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Class representing an Event Grid data connection. </summary>
    public partial class KustoEventGridDataConnection : KustoDataConnectionData
    {
        /// <summary> Initializes a new instance of KustoEventGridDataConnection. </summary>
        public KustoEventGridDataConnection()
        {
            Kind = DataConnectionKind.EventGrid;
        }

        /// <summary> Initializes a new instance of KustoEventGridDataConnection. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the endpoint for the data connection. </param>
        /// <param name="storageAccountResourceId"> The resource ID of the storage account where the data resides. </param>
        /// <param name="eventGridResourceId"> The resource ID of the event grid that is subscribed to the storage account events. </param>
        /// <param name="eventHubResourceId"> The resource ID where the event grid is configured to send events. </param>
        /// <param name="consumerGroup"> The event hub consumer group. </param>
        /// <param name="tableName"> The table where the data should be ingested. Optionally the table information can be added to each message. </param>
        /// <param name="mappingRuleName"> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </param>
        /// <param name="dataFormat"> The data format of the message. Optionally the data format can be added to each message. </param>
        /// <param name="isFirstRecordIgnored"> A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file. </param>
        /// <param name="blobStorageEventType"> The name of blob storage event type to process. </param>
        /// <param name="managedIdentityResourceId"> Empty for non-managed identity based data connection. For system assigned identity, provide cluster resource Id.  For user assigned identity (UAI) provide the UAI resource Id. </param>
        /// <param name="managedIdentityObjectId"> The object ID of managedIdentityResourceId. </param>
        /// <param name="databaseRouting"> Indication for database routing information from the data connection, by default only database routing information is allowed. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        internal KustoEventGridDataConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, DataConnectionKind kind, ResourceIdentifier storageAccountResourceId, ResourceIdentifier eventGridResourceId, ResourceIdentifier eventHubResourceId, string consumerGroup, string tableName, string mappingRuleName, KustoEventGridDataFormat? dataFormat, bool? isFirstRecordIgnored, BlobStorageEventType? blobStorageEventType, ResourceIdentifier managedIdentityResourceId, Guid? managedIdentityObjectId, KustoDatabaseRouting? databaseRouting, KustoProvisioningState? provisioningState) : base(id, name, resourceType, systemData, location, kind)
        {
            StorageAccountResourceId = storageAccountResourceId;
            EventGridResourceId = eventGridResourceId;
            EventHubResourceId = eventHubResourceId;
            ConsumerGroup = consumerGroup;
            TableName = tableName;
            MappingRuleName = mappingRuleName;
            DataFormat = dataFormat;
            IsFirstRecordIgnored = isFirstRecordIgnored;
            BlobStorageEventType = blobStorageEventType;
            ManagedIdentityResourceId = managedIdentityResourceId;
            ManagedIdentityObjectId = managedIdentityObjectId;
            DatabaseRouting = databaseRouting;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> The resource ID of the storage account where the data resides. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; set; }
        /// <summary> The resource ID of the event grid that is subscribed to the storage account events. </summary>
        public ResourceIdentifier EventGridResourceId { get; set; }
        /// <summary> The resource ID where the event grid is configured to send events. </summary>
        public ResourceIdentifier EventHubResourceId { get; set; }
        /// <summary> The event hub consumer group. </summary>
        public string ConsumerGroup { get; set; }
        /// <summary> The table where the data should be ingested. Optionally the table information can be added to each message. </summary>
        public string TableName { get; set; }
        /// <summary> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </summary>
        public string MappingRuleName { get; set; }
        /// <summary> The data format of the message. Optionally the data format can be added to each message. </summary>
        public KustoEventGridDataFormat? DataFormat { get; set; }
        /// <summary> A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file. </summary>
        public bool? IsFirstRecordIgnored { get; set; }
        /// <summary> The name of blob storage event type to process. </summary>
        public BlobStorageEventType? BlobStorageEventType { get; set; }
        /// <summary> Empty for non-managed identity based data connection. For system assigned identity, provide cluster resource Id.  For user assigned identity (UAI) provide the UAI resource Id. </summary>
        public ResourceIdentifier ManagedIdentityResourceId { get; set; }
        /// <summary> The object ID of managedIdentityResourceId. </summary>
        public Guid? ManagedIdentityObjectId { get; }
        /// <summary> Indication for database routing information from the data connection, by default only database routing information is allowed. </summary>
        public KustoDatabaseRouting? DatabaseRouting { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public KustoProvisioningState? ProvisioningState { get; }
    }
}
