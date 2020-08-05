// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ConnectorGroupRequestBuilder.
    /// </summary>
    public partial class ConnectorGroupRequestBuilder : EntityRequestBuilder, IConnectorGroupRequestBuilder
    {

        /// <summary>
        /// Constructs a new ConnectorGroupRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ConnectorGroupRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IConnectorGroupRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IConnectorGroupRequest Request(IEnumerable<Option> options)
        {
            return new ConnectorGroupRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IConnectorGroupMembersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IConnectorGroupMembersCollectionWithReferencesRequestBuilder Members
        {
            get
            {
                return new ConnectorGroupMembersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("members"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Applications.
        /// </summary>
        /// <returns>The <see cref="IConnectorGroupApplicationsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IConnectorGroupApplicationsCollectionWithReferencesRequestBuilder Applications
        {
            get
            {
                return new ConnectorGroupApplicationsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("applications"), this.Client);
            }
        }
    
    }
}
