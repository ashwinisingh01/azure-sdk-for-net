// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class CustomAlertRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("isEnabled");
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType);
            writer.WriteEndObject();
        }

        internal static CustomAlertRule DeserializeCustomAlertRule(JsonElement element)
        {
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AllowlistCustomAlertRule": return AllowlistCustomAlertRule.DeserializeAllowlistCustomAlertRule(element);
                    case "AmqpC2DMessagesNotInAllowedRange": return AmqpC2DMessagesNotInAllowedRange.DeserializeAmqpC2DMessagesNotInAllowedRange(element);
                    case "AmqpC2DRejectedMessagesNotInAllowedRange": return AmqpC2DRejectedMessagesNotInAllowedRange.DeserializeAmqpC2DRejectedMessagesNotInAllowedRange(element);
                    case "AmqpD2CMessagesNotInAllowedRange": return AmqpD2CMessagesNotInAllowedRange.DeserializeAmqpD2CMessagesNotInAllowedRange(element);
                    case "ConnectionFromIpNotAllowed": return ConnectionFromIPNotAllowed.DeserializeConnectionFromIPNotAllowed(element);
                    case "ConnectionToIpNotAllowed": return ConnectionToIPNotAllowed.DeserializeConnectionToIPNotAllowed(element);
                    case "DenylistCustomAlertRule": return DenylistCustomAlertRule.DeserializeDenylistCustomAlertRule(element);
                    case "DirectMethodInvokesNotInAllowedRange": return DirectMethodInvokesNotInAllowedRange.DeserializeDirectMethodInvokesNotInAllowedRange(element);
                    case "FailedLocalLoginsNotInAllowedRange": return FailedLocalLoginsNotInAllowedRange.DeserializeFailedLocalLoginsNotInAllowedRange(element);
                    case "FileUploadsNotInAllowedRange": return FileUploadsNotInAllowedRange.DeserializeFileUploadsNotInAllowedRange(element);
                    case "HttpC2DMessagesNotInAllowedRange": return HttpC2DMessagesNotInAllowedRange.DeserializeHttpC2DMessagesNotInAllowedRange(element);
                    case "HttpC2DRejectedMessagesNotInAllowedRange": return HttpC2DRejectedMessagesNotInAllowedRange.DeserializeHttpC2DRejectedMessagesNotInAllowedRange(element);
                    case "HttpD2CMessagesNotInAllowedRange": return HttpD2CMessagesNotInAllowedRange.DeserializeHttpD2CMessagesNotInAllowedRange(element);
                    case "ListCustomAlertRule": return ListCustomAlertRule.DeserializeListCustomAlertRule(element);
                    case "LocalUserNotAllowed": return LocalUserNotAllowed.DeserializeLocalUserNotAllowed(element);
                    case "MqttC2DMessagesNotInAllowedRange": return MqttC2DMessagesNotInAllowedRange.DeserializeMqttC2DMessagesNotInAllowedRange(element);
                    case "MqttC2DRejectedMessagesNotInAllowedRange": return MqttC2DRejectedMessagesNotInAllowedRange.DeserializeMqttC2DRejectedMessagesNotInAllowedRange(element);
                    case "MqttD2CMessagesNotInAllowedRange": return MqttD2CMessagesNotInAllowedRange.DeserializeMqttD2CMessagesNotInAllowedRange(element);
                    case "ProcessNotAllowed": return ProcessNotAllowed.DeserializeProcessNotAllowed(element);
                    case "QueuePurgesNotInAllowedRange": return QueuePurgesNotInAllowedRange.DeserializeQueuePurgesNotInAllowedRange(element);
                    case "TwinUpdatesNotInAllowedRange": return TwinUpdatesNotInAllowedRange.DeserializeTwinUpdatesNotInAllowedRange(element);
                    case "UnauthorizedOperationsNotInAllowedRange": return UnauthorizedOperationsNotInAllowedRange.DeserializeUnauthorizedOperationsNotInAllowedRange(element);
                    case "ActiveConnectionsNotInAllowedRange": return ActiveConnectionsNotInAllowedRange.DeserializeActiveConnectionsNotInAllowedRange(element);
                    case "TimeWindowCustomAlertRule": return TimeWindowCustomAlertRule.DeserializeTimeWindowCustomAlertRule(element);
                    case "ThresholdCustomAlertRule": return ThresholdCustomAlertRule.DeserializeThresholdCustomAlertRule(element);
                }
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            bool isEnabled = default;
            string ruleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownCustomAlertRule(displayName.Value, description.Value, isEnabled, ruleType);
        }
    }
}
