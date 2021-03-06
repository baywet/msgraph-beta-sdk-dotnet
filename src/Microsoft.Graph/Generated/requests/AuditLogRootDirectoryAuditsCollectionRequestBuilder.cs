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
    /// The type AuditLogRootDirectoryAuditsCollectionRequestBuilder.
    /// </summary>
    public partial class AuditLogRootDirectoryAuditsCollectionRequestBuilder : BaseRequestBuilder, IAuditLogRootDirectoryAuditsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuditLogRootDirectoryAuditsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuditLogRootDirectoryAuditsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuditLogRootDirectoryAuditsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuditLogRootDirectoryAuditsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuditLogRootDirectoryAuditsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryAuditRequestBuilder"/> for the specified AuditLogRootDirectoryAudit.
        /// </summary>
        /// <param name="id">The ID for the AuditLogRootDirectoryAudit.</param>
        /// <returns>The <see cref="IDirectoryAuditRequestBuilder"/>.</returns>
        public IDirectoryAuditRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryAuditRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
