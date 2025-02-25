// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the status and behavior of a service. </summary>
    public partial class ServiceStatus
    {
        /// <summary> Initializes a new instance of ServiceStatus. </summary>
        public ServiceStatus()
        {
        }

        /// <summary> Initializes a new instance of ServiceStatus. </summary>
        /// <param name="status"> The current status of the service. </param>
        /// <param name="startupType"> The behavior of the service when the Arc-enabled machine starts up. </param>
        internal ServiceStatus(string status, string startupType)
        {
            Status = status;
            StartupType = startupType;
        }

        /// <summary> The current status of the service. </summary>
        public string Status { get; set; }
        /// <summary> The behavior of the service when the Arc-enabled machine starts up. </summary>
        public string StartupType { get; set; }
    }
}
