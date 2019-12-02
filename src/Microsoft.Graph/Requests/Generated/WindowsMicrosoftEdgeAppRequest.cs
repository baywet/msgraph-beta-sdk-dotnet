// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WindowsMicrosoftEdgeAppRequest.
    /// </summary>
    public partial class WindowsMicrosoftEdgeAppRequest : BaseRequest, IWindowsMicrosoftEdgeAppRequest
    {
        /// <summary>
        /// Constructs a new WindowsMicrosoftEdgeAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsMicrosoftEdgeAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsMicrosoftEdgeApp using POST.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToCreate">The WindowsMicrosoftEdgeApp to create.</param>
        /// <returns>The created WindowsMicrosoftEdgeApp.</returns>
        public System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> CreateAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToCreate)
        {
            return this.CreateAsync(windowsMicrosoftEdgeAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsMicrosoftEdgeApp using POST.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToCreate">The WindowsMicrosoftEdgeApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsMicrosoftEdgeApp.</returns>
        public async System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> CreateAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsMicrosoftEdgeApp>(windowsMicrosoftEdgeAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WindowsMicrosoftEdgeApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsMicrosoftEdgeApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsMicrosoftEdgeApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsMicrosoftEdgeApp.
        /// </summary>
        /// <returns>The WindowsMicrosoftEdgeApp.</returns>
        public System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsMicrosoftEdgeApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsMicrosoftEdgeApp.</returns>
        public async System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsMicrosoftEdgeApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsMicrosoftEdgeApp using PATCH.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToUpdate">The WindowsMicrosoftEdgeApp to update.</param>
        /// <returns>The updated WindowsMicrosoftEdgeApp.</returns>
        public System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> UpdateAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToUpdate)
        {
            return this.UpdateAsync(windowsMicrosoftEdgeAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsMicrosoftEdgeApp using PATCH.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToUpdate">The WindowsMicrosoftEdgeApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsMicrosoftEdgeApp.</returns>
        public async System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> UpdateAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken)
        {
			if (windowsMicrosoftEdgeAppToUpdate.AdditionalData != null)
			{
				if (windowsMicrosoftEdgeAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windowsMicrosoftEdgeAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsMicrosoftEdgeAppToUpdate.GetType().Name)
						});
				}
			}
            if (windowsMicrosoftEdgeAppToUpdate.AdditionalData != null)
            {
                if (windowsMicrosoftEdgeAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windowsMicrosoftEdgeAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsMicrosoftEdgeAppToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsMicrosoftEdgeApp>(windowsMicrosoftEdgeAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsMicrosoftEdgeAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsMicrosoftEdgeAppRequest Expand(Expression<Func<WindowsMicrosoftEdgeApp, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsMicrosoftEdgeAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsMicrosoftEdgeAppRequest Select(Expression<Func<WindowsMicrosoftEdgeApp, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToInitialize">The <see cref="WindowsMicrosoftEdgeApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToInitialize)
        {

        }
    }
}
