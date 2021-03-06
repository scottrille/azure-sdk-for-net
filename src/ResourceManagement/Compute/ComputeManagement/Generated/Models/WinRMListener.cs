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

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes Protocol and thumbprint of Windows Remote Management listener
    /// </summary>
    public partial class WinRMListener
    {
        private Uri _certificateUrl;
        
        /// <summary>
        /// Optional. Gets or sets the Certificate URL in KMS for Https
        /// listeners. Should be null for Http listeners.
        /// </summary>
        public Uri CertificateUrl
        {
            get { return this._certificateUrl; }
            set { this._certificateUrl = value; }
        }
        
        private string _protocol;
        
        /// <summary>
        /// Optional. Gets or sets the Protocol used by WinRM listener.
        /// Currently only Http and Https are supported.
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WinRMListener class.
        /// </summary>
        public WinRMListener()
        {
        }
    }
}
