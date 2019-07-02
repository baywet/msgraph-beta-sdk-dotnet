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
    /// The interface IJournalRequest.
    /// </summary>
    public partial interface IJournalRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Journal using POST.
        /// </summary>
        /// <param name="journalToCreate">The Journal to create.</param>
        /// <returns>The created Journal.</returns>
        System.Threading.Tasks.Task<Journal> CreateAsync(Journal journalToCreate);        /// <summary>
        /// Creates the specified Journal using POST.
        /// </summary>
        /// <param name="journalToCreate">The Journal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Journal.</returns>
        System.Threading.Tasks.Task<Journal> CreateAsync(Journal journalToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Journal.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Journal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Journal.
        /// </summary>
        /// <returns>The Journal.</returns>
        System.Threading.Tasks.Task<Journal> GetAsync();

        /// <summary>
        /// Gets the specified Journal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Journal.</returns>
        System.Threading.Tasks.Task<Journal> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Journal using PATCH.
        /// </summary>
        /// <param name="journalToUpdate">The Journal to update.</param>
        /// <returns>The updated Journal.</returns>
        System.Threading.Tasks.Task<Journal> UpdateAsync(Journal journalToUpdate);

        /// <summary>
        /// Updates the specified Journal using PATCH.
        /// </summary>
        /// <param name="journalToUpdate">The Journal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Journal.</returns>
        System.Threading.Tasks.Task<Journal> UpdateAsync(Journal journalToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IJournalRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IJournalRequest Expand(Expression<Func<Journal, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IJournalRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IJournalRequest Select(Expression<Func<Journal, object>> selectExpression);

    }
}
