// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookTableSortRequestBuilder.
    /// </summary>
    public partial class WorkbookTableSortRequestBuilder : EntityRequestBuilder, IWorkbookTableSortRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookTableSortRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookTableSortRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookTableSortRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookTableSortRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookTableSortRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for WorkbookTableSortApply.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableSortApplyRequestBuilder"/>.</returns>
        public IWorkbookTableSortApplyRequestBuilder Apply(
            bool matchCase,
            string method,
            IEnumerable<WorkbookSortField> fields = null)
        {
            return new WorkbookTableSortApplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.apply"),
                this.Client,
                matchCase,
                method,
                fields);
        }

        /// <summary>
        /// Gets the request builder for WorkbookTableSortClear.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableSortClearRequestBuilder"/>.</returns>
        public IWorkbookTableSortClearRequestBuilder Clear()
        {
            return new WorkbookTableSortClearRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.clear"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for WorkbookTableSortReapply.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableSortReapplyRequestBuilder"/>.</returns>
        public IWorkbookTableSortReapplyRequestBuilder Reapply()
        {
            return new WorkbookTableSortReapplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reapply"),
                this.Client);
        }
    
    }
}
