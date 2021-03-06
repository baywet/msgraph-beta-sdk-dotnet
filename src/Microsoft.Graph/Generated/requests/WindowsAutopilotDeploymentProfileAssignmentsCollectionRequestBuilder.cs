// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class WindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IWindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsAutopilotDeploymentProfileAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsAutopilotDeploymentProfileAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WindowsAutopilotDeploymentProfileAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsAutopilotDeploymentProfileAssignmentRequestBuilder"/> for the specified WindowsAutopilotDeploymentProfileWindowsAutopilotDeploymentProfileAssignment.
        /// </summary>
        /// <param name="id">The ID for the WindowsAutopilotDeploymentProfileWindowsAutopilotDeploymentProfileAssignment.</param>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileAssignmentRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeploymentProfileAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new WindowsAutopilotDeploymentProfileAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
