// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PrinterSharesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class PrinterSharesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IPrinterSharesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrinterSharesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrinterSharesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPrinterSharesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPrinterSharesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new PrinterSharesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPrinterShareWithReferenceRequestBuilder"/> for the specified PrinterPrinterShare.
        /// </summary>
        /// <param name="id">The ID for the PrinterPrinterShare.</param>
        /// <returns>The <see cref="IPrinterShareWithReferenceRequestBuilder"/>.</returns>
        public IPrinterShareWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new PrinterShareWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IPrinterSharesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IPrinterSharesCollectionReferencesRequestBuilder"/>.</returns>
        public IPrinterSharesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new PrinterSharesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
