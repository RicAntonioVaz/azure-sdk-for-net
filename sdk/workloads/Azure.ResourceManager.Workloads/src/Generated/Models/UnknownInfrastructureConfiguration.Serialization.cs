// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class UnknownInfrastructureConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("deploymentType");
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("appResourceGroup");
            writer.WriteStringValue(AppResourceGroup);
            writer.WriteEndObject();
        }

        internal static UnknownInfrastructureConfiguration DeserializeUnknownInfrastructureConfiguration(JsonElement element)
        {
            SapDeploymentType deploymentType = default;
            string appResourceGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentType"))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceGroup"))
                {
                    appResourceGroup = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownInfrastructureConfiguration(deploymentType, appResourceGroup);
        }
    }
}
