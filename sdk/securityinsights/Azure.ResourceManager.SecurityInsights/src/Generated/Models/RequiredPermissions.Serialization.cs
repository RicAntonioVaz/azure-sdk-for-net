// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class RequiredPermissions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteBooleanValue(Action.Value);
            }
            if (Optional.IsDefined(Write))
            {
                writer.WritePropertyName("write");
                writer.WriteBooleanValue(Write.Value);
            }
            if (Optional.IsDefined(Read))
            {
                writer.WritePropertyName("read");
                writer.WriteBooleanValue(Read.Value);
            }
            if (Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete");
                writer.WriteBooleanValue(Delete.Value);
            }
            writer.WriteEndObject();
        }

        internal static RequiredPermissions DeserializeRequiredPermissions(JsonElement element)
        {
            Optional<bool> action = default;
            Optional<bool> write = default;
            Optional<bool> read = default;
            Optional<bool> delete = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    action = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("write"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    write = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("read"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    read = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("delete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    delete = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RequiredPermissions(Optional.ToNullable(action), Optional.ToNullable(write), Optional.ToNullable(read), Optional.ToNullable(delete));
        }
    }
}
