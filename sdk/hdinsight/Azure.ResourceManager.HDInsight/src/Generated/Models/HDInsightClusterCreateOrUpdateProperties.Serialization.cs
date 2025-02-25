// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterCreateOrUpdateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterVersion))
            {
                writer.WritePropertyName("clusterVersion");
                writer.WriteStringValue(ClusterVersion);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier.Value.ToString());
            }
            if (Optional.IsDefined(ClusterDefinition))
            {
                writer.WritePropertyName("clusterDefinition");
                writer.WriteObjectValue(ClusterDefinition);
            }
            if (Optional.IsDefined(KafkaRestProperties))
            {
                writer.WritePropertyName("kafkaRestProperties");
                writer.WriteObjectValue(KafkaRestProperties);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile");
                writer.WriteObjectValue(SecurityProfile);
            }
            if (Optional.IsDefined(ComputeProfile))
            {
                writer.WritePropertyName("computeProfile");
                writer.WriteObjectValue(ComputeProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile");
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(DiskEncryptionProperties))
            {
                writer.WritePropertyName("diskEncryptionProperties");
                writer.WriteObjectValue(DiskEncryptionProperties);
            }
            if (Optional.IsDefined(EncryptionInTransitProperties))
            {
                writer.WritePropertyName("encryptionInTransitProperties");
                writer.WriteObjectValue(EncryptionInTransitProperties);
            }
            if (Optional.IsDefined(MinSupportedTlsVersion))
            {
                writer.WritePropertyName("minSupportedTlsVersion");
                writer.WriteStringValue(MinSupportedTlsVersion);
            }
            if (Optional.IsDefined(NetworkProperties))
            {
                writer.WritePropertyName("networkProperties");
                writer.WriteObjectValue(NetworkProperties);
            }
            if (Optional.IsDefined(ComputeIsolationProperties))
            {
                writer.WritePropertyName("computeIsolationProperties");
                writer.WriteObjectValue(ComputeIsolationProperties);
            }
            if (Optional.IsCollectionDefined(PrivateLinkConfigurations))
            {
                writer.WritePropertyName("privateLinkConfigurations");
                writer.WriteStartArray();
                foreach (var item in PrivateLinkConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
