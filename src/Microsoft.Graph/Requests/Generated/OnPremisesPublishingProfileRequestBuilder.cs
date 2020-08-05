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
    /// The type OnPremisesPublishingProfileRequestBuilder.
    /// </summary>
    public partial class OnPremisesPublishingProfileRequestBuilder : EntityRequestBuilder, IOnPremisesPublishingProfileRequestBuilder
    {

        /// <summary>
        /// Constructs a new OnPremisesPublishingProfileRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OnPremisesPublishingProfileRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOnPremisesPublishingProfileRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOnPremisesPublishingProfileRequest Request(IEnumerable<Option> options)
        {
            return new OnPremisesPublishingProfileRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Agents.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfileAgentsCollectionRequestBuilder"/>.</returns>
        public IOnPremisesPublishingProfileAgentsCollectionRequestBuilder Agents
        {
            get
            {
                return new OnPremisesPublishingProfileAgentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("agents"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AgentGroups.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfileAgentGroupsCollectionRequestBuilder"/>.</returns>
        public IOnPremisesPublishingProfileAgentGroupsCollectionRequestBuilder AgentGroups
        {
            get
            {
                return new OnPremisesPublishingProfileAgentGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("agentGroups"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PublishedResources.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfilePublishedResourcesCollectionRequestBuilder"/>.</returns>
        public IOnPremisesPublishingProfilePublishedResourcesCollectionRequestBuilder PublishedResources
        {
            get
            {
                return new OnPremisesPublishingProfilePublishedResourcesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("publishedResources"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Connectors.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfileConnectorsCollectionRequestBuilder"/>.</returns>
        public IOnPremisesPublishingProfileConnectorsCollectionRequestBuilder Connectors
        {
            get
            {
                return new OnPremisesPublishingProfileConnectorsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("connectors"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ConnectorGroups.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfileConnectorGroupsCollectionRequestBuilder"/>.</returns>
        public IOnPremisesPublishingProfileConnectorGroupsCollectionRequestBuilder ConnectorGroups
        {
            get
            {
                return new OnPremisesPublishingProfileConnectorGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("connectorGroups"), this.Client);
            }
        }
    
    }
}
