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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation.Models
{
    /// <summary>
    /// Definition of a cloud service-supporting region in which a item is
    /// located.
    /// </summary>
    public partial class CloudService
    {
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the description of the cloud service region.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _geoRegion;
        
        /// <summary>
        /// Optional. Gets or sets the geographical region in which this cloud
        /// service can run.
        /// </summary>
        public string GeoRegion
        {
            get { return this._geoRegion; }
            set { this._geoRegion = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Optional. Gets or sets thelabel of the cloud service region.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the name of the cloud service.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private IList<AutomationResource> _resources;
        
        /// <summary>
        /// Optional. Gets or sets the list of existing resources installed
        /// into a cloud service region.
        /// </summary>
        public IList<AutomationResource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CloudService class.
        /// </summary>
        public CloudService()
        {
            this.Resources = new LazyList<AutomationResource>();
        }
    }
}
