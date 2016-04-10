// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The definition of a AzureIaaSVMJobTaskDetails object.
    /// </summary>
    public partial class AzureIaaSVMJobTaskDetails : JobTaskDetails
    {
        private TimeSpan _duration;
        
        /// <summary>
        /// Optional. Job Duration
        /// </summary>
        public TimeSpan Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }
        
        private System.DateTime? _endTime;
        
        /// <summary>
        /// Optional. Job EndTime
        /// </summary>
        public System.DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private double? _progressPercentage;
        
        /// <summary>
        /// Optional. Job ProgressPercentage
        /// </summary>
        public double? ProgressPercentage
        {
            get { return this._progressPercentage; }
            set { this._progressPercentage = value; }
        }
        
        private System.DateTime? _startTime;
        
        /// <summary>
        /// Optional. Job StartTime
        /// </summary>
        public System.DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Job Status
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _taskId;
        
        /// <summary>
        /// Optional. Job TaskId
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMJobTaskDetails class.
        /// </summary>
        public AzureIaaSVMJobTaskDetails()
        {
        }
    }
}
