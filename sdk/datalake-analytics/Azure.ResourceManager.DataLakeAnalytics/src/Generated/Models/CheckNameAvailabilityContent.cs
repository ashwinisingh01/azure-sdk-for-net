// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary> Data Lake Analytics account name availability check parameters. </summary>
    public partial class CheckNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityContent. </summary>
        /// <param name="name"> The Data Lake Analytics name to check availability for. </param>
        /// <param name="resourceType"> The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeAnalytics/accounts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CheckNameAvailabilityContent(string name, CheckNameAvailabilityParametersType resourceType)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> The Data Lake Analytics name to check availability for. </summary>
        public string Name { get; }
        /// <summary> The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeAnalytics/accounts. </summary>
        public CheckNameAvailabilityParametersType ResourceType { get; }
    }
}
