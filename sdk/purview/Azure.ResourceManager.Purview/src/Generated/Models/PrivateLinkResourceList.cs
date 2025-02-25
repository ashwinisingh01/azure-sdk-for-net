// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.Purview;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> Paged list of private link resources. </summary>
    internal partial class PrivateLinkResourceList
    {
        /// <summary> Initializes a new instance of PrivateLinkResourceList. </summary>
        /// <param name="value"> Collection of items of type results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PrivateLinkResourceList(IEnumerable<PurviewPrivateLinkResourceData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of PrivateLinkResourceList. </summary>
        /// <param name="count"> Total item count. </param>
        /// <param name="nextLink"> The Url of next result page. </param>
        /// <param name="value"> Collection of items of type results. </param>
        internal PrivateLinkResourceList(long? count, string nextLink, IReadOnlyList<PurviewPrivateLinkResourceData> value)
        {
            Count = count;
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Total item count. </summary>
        public long? Count { get; }
        /// <summary> The Url of next result page. </summary>
        public string NextLink { get; }
        /// <summary> Collection of items of type results. </summary>
        public IReadOnlyList<PurviewPrivateLinkResourceData> Value { get; }
    }
}
