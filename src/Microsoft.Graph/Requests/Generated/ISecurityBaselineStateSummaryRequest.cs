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
    /// The interface ISecurityBaselineStateSummaryRequest.
    /// </summary>
    public partial interface ISecurityBaselineStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecurityBaselineStateSummary using POST.
        /// </summary>
        /// <param name="securityBaselineStateSummaryToCreate">The SecurityBaselineStateSummary to create.</param>
        /// <returns>The created SecurityBaselineStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineStateSummary> CreateAsync(SecurityBaselineStateSummary securityBaselineStateSummaryToCreate);        /// <summary>
        /// Creates the specified SecurityBaselineStateSummary using POST.
        /// </summary>
        /// <param name="securityBaselineStateSummaryToCreate">The SecurityBaselineStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityBaselineStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineStateSummary> CreateAsync(SecurityBaselineStateSummary securityBaselineStateSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SecurityBaselineStateSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SecurityBaselineStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SecurityBaselineStateSummary.
        /// </summary>
        /// <returns>The SecurityBaselineStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineStateSummary> GetAsync();

        /// <summary>
        /// Gets the specified SecurityBaselineStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityBaselineStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineStateSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SecurityBaselineStateSummary using PATCH.
        /// </summary>
        /// <param name="securityBaselineStateSummaryToUpdate">The SecurityBaselineStateSummary to update.</param>
        /// <returns>The updated SecurityBaselineStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineStateSummary> UpdateAsync(SecurityBaselineStateSummary securityBaselineStateSummaryToUpdate);

        /// <summary>
        /// Updates the specified SecurityBaselineStateSummary using PATCH.
        /// </summary>
        /// <param name="securityBaselineStateSummaryToUpdate">The SecurityBaselineStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityBaselineStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineStateSummary> UpdateAsync(SecurityBaselineStateSummary securityBaselineStateSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineStateSummaryRequest Expand(Expression<Func<SecurityBaselineStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineStateSummaryRequest Select(Expression<Func<SecurityBaselineStateSummary, object>> selectExpression);

    }
}
