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
    /// The type AppleUserInitiatedEnrollmentProfileRequest.
    /// </summary>
    public partial class AppleUserInitiatedEnrollmentProfileRequest : BaseRequest, IAppleUserInitiatedEnrollmentProfileRequest
    {
        /// <summary>
        /// Constructs a new AppleUserInitiatedEnrollmentProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AppleUserInitiatedEnrollmentProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AppleUserInitiatedEnrollmentProfile using POST.
        /// </summary>
        /// <param name="appleUserInitiatedEnrollmentProfileToCreate">The AppleUserInitiatedEnrollmentProfile to create.</param>
        /// <returns>The created AppleUserInitiatedEnrollmentProfile.</returns>
        public System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> CreateAsync(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToCreate)
        {
            return this.CreateAsync(appleUserInitiatedEnrollmentProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AppleUserInitiatedEnrollmentProfile using POST.
        /// </summary>
        /// <param name="appleUserInitiatedEnrollmentProfileToCreate">The AppleUserInitiatedEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppleUserInitiatedEnrollmentProfile.</returns>
        public async System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> CreateAsync(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AppleUserInitiatedEnrollmentProfile>(appleUserInitiatedEnrollmentProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AppleUserInitiatedEnrollmentProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AppleUserInitiatedEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AppleUserInitiatedEnrollmentProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AppleUserInitiatedEnrollmentProfile.
        /// </summary>
        /// <returns>The AppleUserInitiatedEnrollmentProfile.</returns>
        public System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AppleUserInitiatedEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppleUserInitiatedEnrollmentProfile.</returns>
        public async System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AppleUserInitiatedEnrollmentProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AppleUserInitiatedEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="appleUserInitiatedEnrollmentProfileToUpdate">The AppleUserInitiatedEnrollmentProfile to update.</param>
        /// <returns>The updated AppleUserInitiatedEnrollmentProfile.</returns>
        public System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> UpdateAsync(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToUpdate)
        {
            return this.UpdateAsync(appleUserInitiatedEnrollmentProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AppleUserInitiatedEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="appleUserInitiatedEnrollmentProfileToUpdate">The AppleUserInitiatedEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppleUserInitiatedEnrollmentProfile.</returns>
        public async System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> UpdateAsync(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToUpdate, CancellationToken cancellationToken)
        {
			if (appleUserInitiatedEnrollmentProfileToUpdate.AdditionalData != null)
			{
				if (appleUserInitiatedEnrollmentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					appleUserInitiatedEnrollmentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, appleUserInitiatedEnrollmentProfileToUpdate.GetType().Name)
						});
				}
			}
            if (appleUserInitiatedEnrollmentProfileToUpdate.AdditionalData != null)
            {
                if (appleUserInitiatedEnrollmentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    appleUserInitiatedEnrollmentProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, appleUserInitiatedEnrollmentProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AppleUserInitiatedEnrollmentProfile>(appleUserInitiatedEnrollmentProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAppleUserInitiatedEnrollmentProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAppleUserInitiatedEnrollmentProfileRequest Expand(Expression<Func<AppleUserInitiatedEnrollmentProfile, object>> expandExpression)
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
        public IAppleUserInitiatedEnrollmentProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAppleUserInitiatedEnrollmentProfileRequest Select(Expression<Func<AppleUserInitiatedEnrollmentProfile, object>> selectExpression)
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
        /// <param name="appleUserInitiatedEnrollmentProfileToInitialize">The <see cref="AppleUserInitiatedEnrollmentProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToInitialize)
        {

            if (appleUserInitiatedEnrollmentProfileToInitialize != null && appleUserInitiatedEnrollmentProfileToInitialize.AdditionalData != null)
            {

                if (appleUserInitiatedEnrollmentProfileToInitialize.Assignments != null && appleUserInitiatedEnrollmentProfileToInitialize.Assignments.CurrentPage != null)
                {
                    appleUserInitiatedEnrollmentProfileToInitialize.Assignments.AdditionalData = appleUserInitiatedEnrollmentProfileToInitialize.AdditionalData;

                    object nextPageLink;
                    appleUserInitiatedEnrollmentProfileToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        appleUserInitiatedEnrollmentProfileToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
