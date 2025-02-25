// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ProcessEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ElevationToken))
            {
                writer.WritePropertyName("elevationToken");
                writer.WriteStringValue(ElevationToken.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ProcessEntity DeserializeProcessEntity(JsonElement element)
        {
            EntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> accountEntityId = default;
            Optional<string> commandLine = default;
            Optional<DateTimeOffset> creationTimeUtc = default;
            Optional<ElevationToken> elevationToken = default;
            Optional<string> hostEntityId = default;
            Optional<string> hostLogonSessionEntityId = default;
            Optional<string> imageFileEntityId = default;
            Optional<string> parentProcessEntityId = default;
            Optional<string> processId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new EntityKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("additionalData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountEntityId"))
                        {
                            accountEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("commandLine"))
                        {
                            commandLine = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTimeUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("elevationToken"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            elevationToken = property0.Value.GetString().ToElevationToken();
                            continue;
                        }
                        if (property0.NameEquals("hostEntityId"))
                        {
                            hostEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostLogonSessionEntityId"))
                        {
                            hostLogonSessionEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageFileEntityId"))
                        {
                            imageFileEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parentProcessEntityId"))
                        {
                            parentProcessEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("processId"))
                        {
                            processId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProcessEntity(id, name, type, systemData.Value, kind, Optional.ToDictionary(additionalData), friendlyName.Value, accountEntityId.Value, commandLine.Value, Optional.ToNullable(creationTimeUtc), Optional.ToNullable(elevationToken), hostEntityId.Value, hostLogonSessionEntityId.Value, imageFileEntityId.Value, parentProcessEntityId.Value, processId.Value);
        }
    }
}
