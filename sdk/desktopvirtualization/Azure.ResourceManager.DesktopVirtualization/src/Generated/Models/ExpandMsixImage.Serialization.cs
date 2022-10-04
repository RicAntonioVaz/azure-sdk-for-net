// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ExpandMsixImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PackageAlias))
            {
                writer.WritePropertyName("packageAlias");
                writer.WriteStringValue(PackageAlias);
            }
            if (Optional.IsDefined(ImagePath))
            {
                writer.WritePropertyName("imagePath");
                writer.WriteStringValue(ImagePath);
            }
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName");
                writer.WriteStringValue(PackageName);
            }
            if (Optional.IsDefined(PackageFamilyName))
            {
                writer.WritePropertyName("packageFamilyName");
                writer.WriteStringValue(PackageFamilyName);
            }
            if (Optional.IsDefined(PackageFullName))
            {
                writer.WritePropertyName("packageFullName");
                writer.WriteStringValue(PackageFullName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName");
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (Optional.IsDefined(PackageRelativePath))
            {
                writer.WritePropertyName("packageRelativePath");
                writer.WriteStringValue(PackageRelativePath);
            }
            if (Optional.IsDefined(IsRegularRegistration))
            {
                writer.WritePropertyName("isRegularRegistration");
                writer.WriteBooleanValue(IsRegularRegistration.Value);
            }
            if (Optional.IsDefined(IsActive))
            {
                writer.WritePropertyName("isActive");
                writer.WriteBooleanValue(IsActive.Value);
            }
            if (Optional.IsCollectionDefined(PackageDependencies))
            {
                if (PackageDependencies != null)
                {
                    writer.WritePropertyName("packageDependencies");
                    writer.WriteStartArray();
                    foreach (var item in PackageDependencies)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("packageDependencies");
                }
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdated");
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(PackageApplications))
            {
                writer.WritePropertyName("packageApplications");
                writer.WriteStartArray();
                foreach (var item in PackageApplications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpandMsixImage DeserializeExpandMsixImage(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> packageAlias = default;
            Optional<string> imagePath = default;
            Optional<string> packageName = default;
            Optional<string> packageFamilyName = default;
            Optional<string> packageFullName = default;
            Optional<string> displayName = default;
            Optional<string> packageRelativePath = default;
            Optional<bool> isRegularRegistration = default;
            Optional<bool> isActive = default;
            Optional<IList<MsixPackageDependencies>> packageDependencies = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> lastUpdated = default;
            Optional<IList<MsixPackageApplications>> packageApplications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packageAlias"))
                        {
                            packageAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imagePath"))
                        {
                            imagePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageName"))
                        {
                            packageName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFamilyName"))
                        {
                            packageFamilyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFullName"))
                        {
                            packageFullName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                displayName = null;
                                continue;
                            }
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageRelativePath"))
                        {
                            packageRelativePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isRegularRegistration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isRegularRegistration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isActive"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isActive = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("packageDependencies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                packageDependencies = null;
                                continue;
                            }
                            List<MsixPackageDependencies> array = new List<MsixPackageDependencies>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MsixPackageDependencies.DeserializeMsixPackageDependencies(item));
                            }
                            packageDependencies = array;
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdated"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastUpdated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("packageApplications"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<MsixPackageApplications> array = new List<MsixPackageApplications>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MsixPackageApplications.DeserializeMsixPackageApplications(item));
                            }
                            packageApplications = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpandMsixImage(id, name, type, systemData.Value, packageAlias.Value, imagePath.Value, packageName.Value, packageFamilyName.Value, packageFullName.Value, displayName.Value, packageRelativePath.Value, Optional.ToNullable(isRegularRegistration), Optional.ToNullable(isActive), Optional.ToList(packageDependencies), version.Value, Optional.ToNullable(lastUpdated), Optional.ToList(packageApplications));
        }
    }
}
