// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IOnPremisesPublishingProfileRequestBuilder.
    /// </summary>
    public partial interface IOnPremisesPublishingProfileRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IOnPremisesPublishingProfileRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IOnPremisesPublishingProfileRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Agents.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfileAgentsCollectionRequestBuilder"/>.</returns>
        IOnPremisesPublishingProfileAgentsCollectionRequestBuilder Agents { get; }

        /// <summary>
        /// Gets the request builder for AgentGroups.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfileAgentGroupsCollectionRequestBuilder"/>.</returns>
        IOnPremisesPublishingProfileAgentGroupsCollectionRequestBuilder AgentGroups { get; }

        /// <summary>
        /// Gets the request builder for PublishedResources.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfilePublishedResourcesCollectionRequestBuilder"/>.</returns>
        IOnPremisesPublishingProfilePublishedResourcesCollectionRequestBuilder PublishedResources { get; }

        /// <summary>
        /// Gets the request builder for Connectors.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfileConnectorsCollectionRequestBuilder"/>.</returns>
        IOnPremisesPublishingProfileConnectorsCollectionRequestBuilder Connectors { get; }

        /// <summary>
        /// Gets the request builder for ConnectorGroups.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesPublishingProfileConnectorGroupsCollectionRequestBuilder"/>.</returns>
        IOnPremisesPublishingProfileConnectorGroupsCollectionRequestBuilder ConnectorGroups { get; }
    
    }
}
