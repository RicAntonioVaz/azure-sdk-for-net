// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class WorkspaceCapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DailyQuotaGb))
            {
                writer.WritePropertyName("dailyQuotaGb");
                writer.WriteNumberValue(DailyQuotaGb.Value);
            }
            writer.WriteEndObject();
        }

        internal static WorkspaceCapping DeserializeWorkspaceCapping(JsonElement element)
        {
            Optional<double> dailyQuotaGb = default;
            Optional<string> quotaNextResetTime = default;
            Optional<DataIngestionStatus> dataIngestionStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dailyQuotaGb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dailyQuotaGb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("quotaNextResetTime"))
                {
                    quotaNextResetTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataIngestionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataIngestionStatus = new DataIngestionStatus(property.Value.GetString());
                    continue;
                }
            }
            return new WorkspaceCapping(Optional.ToNullable(dailyQuotaGb), quotaNextResetTime.Value, Optional.ToNullable(dataIngestionStatus));
        }
    }
}
