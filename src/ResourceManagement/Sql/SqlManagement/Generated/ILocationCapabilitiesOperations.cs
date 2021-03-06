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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql.Responses;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations for determining the set of capabilites
    /// available in a specified region.
    /// </summary>
    public partial interface ILocationCapabilitiesOperations
    {
        /// <summary>
        /// Returns information about the Azure SQL capabilities available for
        /// the specified region.
        /// </summary>
        /// <param name='locationName'>
        /// The name of the region for which the Azure SQL capabilities are
        /// retrieved.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql capabilities request
        /// </returns>
        Task<LocationCapabilitiesGetResponse> GetAsync(string locationName, CancellationToken cancellationToken);
    }
}
