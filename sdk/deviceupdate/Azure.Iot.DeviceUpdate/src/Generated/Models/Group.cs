// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> Group details. </summary>
    public partial class Group
    {
        /// <summary> Initializes a new instance of Group. </summary>
        /// <param name="groupId"> Group identity. </param>
        /// <param name="groupType"> Group type. </param>
        /// <param name="tags"> IoT Hub tags. </param>
        /// <param name="createdDateTime"> Date and time when the update was created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/>, <paramref name="tags"/>, or <paramref name="createdDateTime"/> is null. </exception>
        public Group(string groupId, GroupType groupType, IEnumerable<string> tags, string createdDateTime)
        {
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }
            if (createdDateTime == null)
            {
                throw new ArgumentNullException(nameof(createdDateTime));
            }

            GroupId = groupId;
            GroupType = groupType;
            Tags = tags.ToList();
            CreatedDateTime = createdDateTime;
        }

        /// <summary> Initializes a new instance of Group. </summary>
        /// <param name="groupId"> Group identity. </param>
        /// <param name="groupType"> Group type. </param>
        /// <param name="tags"> IoT Hub tags. </param>
        /// <param name="createdDateTime"> Date and time when the update was created. </param>
        /// <param name="deviceCount"> The number of devices in the group. </param>
        internal Group(string groupId, GroupType groupType, IList<string> tags, string createdDateTime, int? deviceCount)
        {
            GroupId = groupId;
            GroupType = groupType;
            Tags = tags;
            CreatedDateTime = createdDateTime;
            DeviceCount = deviceCount;
        }

        /// <summary> Group identity. </summary>
        public string GroupId { get; set; }
        /// <summary> Group type. </summary>
        public GroupType GroupType { get; set; }
        /// <summary> IoT Hub tags. </summary>
        public IList<string> Tags { get; }
        /// <summary> Date and time when the update was created. </summary>
        public string CreatedDateTime { get; set; }
        /// <summary> The number of devices in the group. </summary>
        public int? DeviceCount { get; set; }
    }
}
