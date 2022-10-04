// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabVirtualMachineCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("username");
            writer.WriteStringValue(Username);
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            writer.WriteEndObject();
        }

        internal static LabVirtualMachineCredential DeserializeLabVirtualMachineCredential(JsonElement element)
        {
            string username = default;
            Optional<string> password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
            }
            return new LabVirtualMachineCredential(username, password.Value);
        }
    }
}
