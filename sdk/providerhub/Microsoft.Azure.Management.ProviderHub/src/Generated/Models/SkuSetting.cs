// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SkuSetting
    {
        /// <summary>
        /// Initializes a new instance of the SkuSetting class.
        /// </summary>
        public SkuSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuSetting class.
        /// </summary>
        public SkuSetting(string name, string tier = default(string), string size = default(string), string family = default(string), string kind = default(string), IList<string> locations = default(IList<string>), IList<SkuLocationInfo> locationInfo = default(IList<SkuLocationInfo>), IList<string> requiredQuotaIds = default(IList<string>), IList<string> requiredFeatures = default(IList<string>), SkuSettingCapacity capacity = default(SkuSettingCapacity), IList<SkuCost> costs = default(IList<SkuCost>), IList<SkuCapability> capabilities = default(IList<SkuCapability>))
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Kind = kind;
            Locations = locations;
            LocationInfo = locationInfo;
            RequiredQuotaIds = requiredQuotaIds;
            RequiredFeatures = requiredFeatures;
            Capacity = capacity;
            Costs = costs;
            Capabilities = capabilities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locationInfo")]
        public IList<SkuLocationInfo> LocationInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredQuotaIds")]
        public IList<string> RequiredQuotaIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredFeatures")]
        public IList<string> RequiredFeatures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public SkuSettingCapacity Capacity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "costs")]
        public IList<SkuCost> Costs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<SkuCapability> Capabilities { get; set; }

    }
}
