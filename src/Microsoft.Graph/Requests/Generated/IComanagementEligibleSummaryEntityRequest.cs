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
    /// The interface IComanagementEligibleSummaryEntityRequest.
    /// </summary>
    public partial interface IComanagementEligibleSummaryEntityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ComanagementEligibleSummaryEntity using POST.
        /// </summary>
        /// <param name="comanagementEligibleSummaryEntityToCreate">The ComanagementEligibleSummaryEntity to create.</param>
        /// <returns>The created ComanagementEligibleSummaryEntity.</returns>
        System.Threading.Tasks.Task<ComanagementEligibleSummaryEntity> CreateAsync(ComanagementEligibleSummaryEntity comanagementEligibleSummaryEntityToCreate);        /// <summary>
        /// Creates the specified ComanagementEligibleSummaryEntity using POST.
        /// </summary>
        /// <param name="comanagementEligibleSummaryEntityToCreate">The ComanagementEligibleSummaryEntity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ComanagementEligibleSummaryEntity.</returns>
        System.Threading.Tasks.Task<ComanagementEligibleSummaryEntity> CreateAsync(ComanagementEligibleSummaryEntity comanagementEligibleSummaryEntityToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ComanagementEligibleSummaryEntity.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ComanagementEligibleSummaryEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ComanagementEligibleSummaryEntity.
        /// </summary>
        /// <returns>The ComanagementEligibleSummaryEntity.</returns>
        System.Threading.Tasks.Task<ComanagementEligibleSummaryEntity> GetAsync();

        /// <summary>
        /// Gets the specified ComanagementEligibleSummaryEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ComanagementEligibleSummaryEntity.</returns>
        System.Threading.Tasks.Task<ComanagementEligibleSummaryEntity> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ComanagementEligibleSummaryEntity using PATCH.
        /// </summary>
        /// <param name="comanagementEligibleSummaryEntityToUpdate">The ComanagementEligibleSummaryEntity to update.</param>
        /// <returns>The updated ComanagementEligibleSummaryEntity.</returns>
        System.Threading.Tasks.Task<ComanagementEligibleSummaryEntity> UpdateAsync(ComanagementEligibleSummaryEntity comanagementEligibleSummaryEntityToUpdate);

        /// <summary>
        /// Updates the specified ComanagementEligibleSummaryEntity using PATCH.
        /// </summary>
        /// <param name="comanagementEligibleSummaryEntityToUpdate">The ComanagementEligibleSummaryEntity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ComanagementEligibleSummaryEntity.</returns>
        System.Threading.Tasks.Task<ComanagementEligibleSummaryEntity> UpdateAsync(ComanagementEligibleSummaryEntity comanagementEligibleSummaryEntityToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IComanagementEligibleSummaryEntityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IComanagementEligibleSummaryEntityRequest Expand(Expression<Func<ComanagementEligibleSummaryEntity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IComanagementEligibleSummaryEntityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IComanagementEligibleSummaryEntityRequest Select(Expression<Func<ComanagementEligibleSummaryEntity, object>> selectExpression);

    }
}