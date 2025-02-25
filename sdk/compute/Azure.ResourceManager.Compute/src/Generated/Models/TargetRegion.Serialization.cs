// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class TargetRegion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(RegionalReplicaCount))
            {
                writer.WritePropertyName("regionalReplicaCount");
                writer.WriteNumberValue(RegionalReplicaCount.Value);
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            writer.WriteEndObject();
        }

        internal static TargetRegion DeserializeTargetRegion(JsonElement element)
        {
            string name = default;
            Optional<int> regionalReplicaCount = default;
            Optional<ImageStorageAccountType> storageAccountType = default;
            Optional<EncryptionImages> encryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionalReplicaCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    regionalReplicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageAccountType = new ImageStorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encryption = EncryptionImages.DeserializeEncryptionImages(property.Value);
                    continue;
                }
            }
            return new TargetRegion(name, Optional.ToNullable(regionalReplicaCount), Optional.ToNullable(storageAccountType), encryption.Value);
        }
    }
}
