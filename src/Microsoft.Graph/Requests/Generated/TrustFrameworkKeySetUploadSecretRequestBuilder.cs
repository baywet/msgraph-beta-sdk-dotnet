// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type TrustFrameworkKeySetUploadSecretRequestBuilder.
    /// </summary>
    public partial class TrustFrameworkKeySetUploadSecretRequestBuilder : BaseActionMethodRequestBuilder<ITrustFrameworkKeySetUploadSecretRequest>, ITrustFrameworkKeySetUploadSecretRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="TrustFrameworkKeySetUploadSecretRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="use">A use parameter for the OData method call.</param>
        /// <param name="k">A k parameter for the OData method call.</param>
        /// <param name="nbf">A nbf parameter for the OData method call.</param>
        /// <param name="exp">A exp parameter for the OData method call.</param>
        public TrustFrameworkKeySetUploadSecretRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string use,
            string k,
            Int64? nbf,
            Int64? exp)
            : base(requestUrl, client)
        {
            this.SetParameter("use", use, true);
            this.SetParameter("k", k, true);
            this.SetParameter("nbf", nbf, true);
            this.SetParameter("exp", exp, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ITrustFrameworkKeySetUploadSecretRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new TrustFrameworkKeySetUploadSecretRequest(functionUrl, this.Client, options);

            if (this.HasParameter("use"))
            {
                request.RequestBody.Use = this.GetParameter<string>("use");
            }

            if (this.HasParameter("k"))
            {
                request.RequestBody.K = this.GetParameter<string>("k");
            }

            if (this.HasParameter("nbf"))
            {
                request.RequestBody.Nbf = this.GetParameter<Int64?>("nbf");
            }

            if (this.HasParameter("exp"))
            {
                request.RequestBody.Exp = this.GetParameter<Int64?>("exp");
            }

            return request;
        }
    }
}