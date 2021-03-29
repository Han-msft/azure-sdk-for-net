// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> The current status of an async operation. </summary>
    public partial class OperationStatus
    {
        /// <summary> Initializes a new instance of OperationStatus. </summary>
        internal OperationStatus()
        {
        }

        /// <summary> Initializes a new instance of OperationStatus. </summary>
        /// <param name="id"> Fully qualified ID for the operation status. </param>
        /// <param name="status"> Provisioning state of the resource. </param>
        /// <param name="startTime"> The start time of the operation. </param>
        /// <param name="endTime"> The end time of the operation. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="error"> The error object. </param>
        internal OperationStatus(string id, Status? status, DateTimeOffset? startTime, DateTimeOffset? endTime, float? percentComplete, ErrorDetail error)
        {
            Id = id;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            PercentComplete = percentComplete;
            Error = error;
        }

        /// <summary> Fully qualified ID for the operation status. </summary>
        public string Id { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public Status? Status { get; }
        /// <summary> The start time of the operation. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end time of the operation. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> Percent of the operation that is complete. </summary>
        public float? PercentComplete { get; }
        /// <summary> The error object. </summary>
        public ErrorDetail Error { get; }
    }
}
