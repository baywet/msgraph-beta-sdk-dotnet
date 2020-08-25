// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IStoreSetsCollectionRequestBuilder.
    /// </summary>
    public partial interface IStoreSetsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IStoreSetsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IStoreSetsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="ISetRequestBuilder"/> for the specified Set.
        /// </summary>
        /// <param name="id">The ID for the Set.</param>
        /// <returns>The <see cref="ISetRequestBuilder"/>.</returns>
        ISetRequestBuilder this[string id] { get; }

        
    }
}
