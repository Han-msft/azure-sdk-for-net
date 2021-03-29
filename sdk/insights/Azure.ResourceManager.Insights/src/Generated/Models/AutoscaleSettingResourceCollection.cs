// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Represents a collection of autoscale setting resources. </summary>
    internal partial class AutoscaleSettingResourceCollection
    {
        /// <summary> Initializes a new instance of AutoscaleSettingResourceCollection. </summary>
        /// <param name="value"> the values for the autoscale setting resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AutoscaleSettingResourceCollection(IEnumerable<AutoscaleSettingResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of AutoscaleSettingResourceCollection. </summary>
        /// <param name="value"> the values for the autoscale setting resources. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal AutoscaleSettingResourceCollection(IReadOnlyList<AutoscaleSettingResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> the values for the autoscale setting resources. </summary>
        public IReadOnlyList<AutoscaleSettingResource> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
