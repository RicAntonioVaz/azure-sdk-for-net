// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderItemDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("productDetails");
            writer.WriteObjectValue(ProductDetails);
            writer.WritePropertyName("orderItemType");
            writer.WriteStringValue(OrderItemType.ToString());
            if (Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences");
                writer.WriteObjectValue(Preferences);
            }
            if (Optional.IsCollectionDefined(NotificationEmailList))
            {
                writer.WritePropertyName("notificationEmailList");
                writer.WriteStartArray();
                foreach (var item in NotificationEmailList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EdgeOrderItemDetails DeserializeEdgeOrderItemDetails(JsonElement element)
        {
            ProductDetails productDetails = default;
            OrderItemType orderItemType = default;
            Optional<EdgeOrderStageDetails> currentStage = default;
            Optional<IReadOnlyList<EdgeOrderStageDetails>> orderItemStageHistory = default;
            Optional<OrderItemPreferences> preferences = default;
            Optional<ForwardShippingDetails> forwardShippingDetails = default;
            Optional<ReverseShippingDetails> reverseShippingDetails = default;
            Optional<IList<string>> notificationEmailList = default;
            Optional<string> cancellationReason = default;
            Optional<OrderItemCancellationStatus> cancellationStatus = default;
            Optional<EdgeOrderActionStatus> deletionStatus = default;
            Optional<string> returnReason = default;
            Optional<OrderItemReturnStatus> returnStatus = default;
            Optional<ResourceProviderDetails> managementRPDetails = default;
            Optional<IReadOnlyList<ResourceProviderDetails>> managementRPDetailsList = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productDetails"))
                {
                    productDetails = ProductDetails.DeserializeProductDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("orderItemType"))
                {
                    orderItemType = new OrderItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentStage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentStage = EdgeOrderStageDetails.DeserializeEdgeOrderStageDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("orderItemStageHistory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EdgeOrderStageDetails> array = new List<EdgeOrderStageDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdgeOrderStageDetails.DeserializeEdgeOrderStageDetails(item));
                    }
                    orderItemStageHistory = array;
                    continue;
                }
                if (property.NameEquals("preferences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preferences = OrderItemPreferences.DeserializeOrderItemPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("forwardShippingDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    forwardShippingDetails = ForwardShippingDetails.DeserializeForwardShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("notificationEmailList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    notificationEmailList = array;
                    continue;
                }
                if (property.NameEquals("cancellationReason"))
                {
                    cancellationReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cancellationStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cancellationStatus = new OrderItemCancellationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deletionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deletionStatus = new EdgeOrderActionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("returnReason"))
                {
                    returnReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("returnStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    returnStatus = new OrderItemReturnStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managementRpDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managementRPDetails = ResourceProviderDetails.DeserializeResourceProviderDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("managementRpDetailsList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceProviderDetails> array = new List<ResourceProviderDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderDetails.DeserializeResourceProviderDetails(item));
                    }
                    managementRPDetailsList = array;
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.ToString());
                    continue;
                }
            }
            return new EdgeOrderItemDetails(productDetails, orderItemType, currentStage.Value, Optional.ToList(orderItemStageHistory), preferences.Value, forwardShippingDetails.Value, reverseShippingDetails.Value, Optional.ToList(notificationEmailList), cancellationReason.Value, Optional.ToNullable(cancellationStatus), Optional.ToNullable(deletionStatus), returnReason.Value, Optional.ToNullable(returnStatus), managementRPDetails.Value, Optional.ToList(managementRPDetailsList), error.Value);
        }
    }
}
