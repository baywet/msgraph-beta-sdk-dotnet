// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IRelyingPartyDetailedSummaryRequest.
    /// </summary>
    public partial interface IRelyingPartyDetailedSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RelyingPartyDetailedSummary using POST.
        /// </summary>
        /// <param name="relyingPartyDetailedSummaryToCreate">The RelyingPartyDetailedSummary to create.</param>
        /// <returns>The created RelyingPartyDetailedSummary.</returns>
        System.Threading.Tasks.Task<RelyingPartyDetailedSummary> CreateAsync(RelyingPartyDetailedSummary relyingPartyDetailedSummaryToCreate);        /// <summary>
        /// Creates the specified RelyingPartyDetailedSummary using POST.
        /// </summary>
        /// <param name="relyingPartyDetailedSummaryToCreate">The RelyingPartyDetailedSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RelyingPartyDetailedSummary.</returns>
        System.Threading.Tasks.Task<RelyingPartyDetailedSummary> CreateAsync(RelyingPartyDetailedSummary relyingPartyDetailedSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RelyingPartyDetailedSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RelyingPartyDetailedSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RelyingPartyDetailedSummary.
        /// </summary>
        /// <returns>The RelyingPartyDetailedSummary.</returns>
        System.Threading.Tasks.Task<RelyingPartyDetailedSummary> GetAsync();

        /// <summary>
        /// Gets the specified RelyingPartyDetailedSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RelyingPartyDetailedSummary.</returns>
        System.Threading.Tasks.Task<RelyingPartyDetailedSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RelyingPartyDetailedSummary using PATCH.
        /// </summary>
        /// <param name="relyingPartyDetailedSummaryToUpdate">The RelyingPartyDetailedSummary to update.</param>
        /// <returns>The updated RelyingPartyDetailedSummary.</returns>
        System.Threading.Tasks.Task<RelyingPartyDetailedSummary> UpdateAsync(RelyingPartyDetailedSummary relyingPartyDetailedSummaryToUpdate);

        /// <summary>
        /// Updates the specified RelyingPartyDetailedSummary using PATCH.
        /// </summary>
        /// <param name="relyingPartyDetailedSummaryToUpdate">The RelyingPartyDetailedSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RelyingPartyDetailedSummary.</returns>
        System.Threading.Tasks.Task<RelyingPartyDetailedSummary> UpdateAsync(RelyingPartyDetailedSummary relyingPartyDetailedSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRelyingPartyDetailedSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRelyingPartyDetailedSummaryRequest Expand(Expression<Func<RelyingPartyDetailedSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRelyingPartyDetailedSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRelyingPartyDetailedSummaryRequest Select(Expression<Func<RelyingPartyDetailedSummary, object>> selectExpression);

    }
}