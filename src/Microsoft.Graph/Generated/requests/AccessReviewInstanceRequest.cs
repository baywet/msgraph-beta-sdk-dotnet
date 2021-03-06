// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AccessReviewInstanceRequest.
    /// </summary>
    public partial class AccessReviewInstanceRequest : BaseRequest, IAccessReviewInstanceRequest
    {
        /// <summary>
        /// Constructs a new AccessReviewInstanceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessReviewInstanceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessReviewInstance using POST.
        /// </summary>
        /// <param name="accessReviewInstanceToCreate">The AccessReviewInstance to create.</param>
        /// <returns>The created AccessReviewInstance.</returns>
        public System.Threading.Tasks.Task<AccessReviewInstance> CreateAsync(AccessReviewInstance accessReviewInstanceToCreate)
        {
            return this.CreateAsync(accessReviewInstanceToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AccessReviewInstance using POST.
        /// </summary>
        /// <param name="accessReviewInstanceToCreate">The AccessReviewInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReviewInstance.</returns>
        public async System.Threading.Tasks.Task<AccessReviewInstance> CreateAsync(AccessReviewInstance accessReviewInstanceToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AccessReviewInstance>(accessReviewInstanceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AccessReviewInstance.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AccessReviewInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AccessReviewInstance>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AccessReviewInstance.
        /// </summary>
        /// <returns>The AccessReviewInstance.</returns>
        public System.Threading.Tasks.Task<AccessReviewInstance> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AccessReviewInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessReviewInstance.</returns>
        public async System.Threading.Tasks.Task<AccessReviewInstance> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AccessReviewInstance>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AccessReviewInstance using PATCH.
        /// </summary>
        /// <param name="accessReviewInstanceToUpdate">The AccessReviewInstance to update.</param>
        /// <returns>The updated AccessReviewInstance.</returns>
        public System.Threading.Tasks.Task<AccessReviewInstance> UpdateAsync(AccessReviewInstance accessReviewInstanceToUpdate)
        {
            return this.UpdateAsync(accessReviewInstanceToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AccessReviewInstance using PATCH.
        /// </summary>
        /// <param name="accessReviewInstanceToUpdate">The AccessReviewInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessReviewInstance.</returns>
        public async System.Threading.Tasks.Task<AccessReviewInstance> UpdateAsync(AccessReviewInstance accessReviewInstanceToUpdate, CancellationToken cancellationToken)
        {
			if (accessReviewInstanceToUpdate.AdditionalData != null)
			{
				if (accessReviewInstanceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					accessReviewInstanceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, accessReviewInstanceToUpdate.GetType().Name)
						});
				}
			}
            if (accessReviewInstanceToUpdate.AdditionalData != null)
            {
                if (accessReviewInstanceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    accessReviewInstanceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, accessReviewInstanceToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AccessReviewInstance>(accessReviewInstanceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewInstanceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewInstanceRequest Expand(Expression<Func<AccessReviewInstance, object>> expandExpression)
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
        public IAccessReviewInstanceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewInstanceRequest Select(Expression<Func<AccessReviewInstance, object>> selectExpression)
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
        /// <param name="accessReviewInstanceToInitialize">The <see cref="AccessReviewInstance"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessReviewInstance accessReviewInstanceToInitialize)
        {

            if (accessReviewInstanceToInitialize != null && accessReviewInstanceToInitialize.AdditionalData != null)
            {

                if (accessReviewInstanceToInitialize.Decisions != null && accessReviewInstanceToInitialize.Decisions.CurrentPage != null)
                {
                    accessReviewInstanceToInitialize.Decisions.AdditionalData = accessReviewInstanceToInitialize.AdditionalData;

                    object nextPageLink;
                    accessReviewInstanceToInitialize.AdditionalData.TryGetValue("decisions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        accessReviewInstanceToInitialize.Decisions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
