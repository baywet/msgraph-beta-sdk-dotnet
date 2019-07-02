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
    /// The interface IEducationUserRequest.
    /// </summary>
    public partial interface IEducationUserRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationUser using POST.
        /// </summary>
        /// <param name="educationUserToCreate">The EducationUser to create.</param>
        /// <returns>The created EducationUser.</returns>
        System.Threading.Tasks.Task<EducationUser> CreateAsync(EducationUser educationUserToCreate);        /// <summary>
        /// Creates the specified EducationUser using POST.
        /// </summary>
        /// <param name="educationUserToCreate">The EducationUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationUser.</returns>
        System.Threading.Tasks.Task<EducationUser> CreateAsync(EducationUser educationUserToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EducationUser.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EducationUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EducationUser.
        /// </summary>
        /// <returns>The EducationUser.</returns>
        System.Threading.Tasks.Task<EducationUser> GetAsync();

        /// <summary>
        /// Gets the specified EducationUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationUser.</returns>
        System.Threading.Tasks.Task<EducationUser> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EducationUser using PATCH.
        /// </summary>
        /// <param name="educationUserToUpdate">The EducationUser to update.</param>
        /// <returns>The updated EducationUser.</returns>
        System.Threading.Tasks.Task<EducationUser> UpdateAsync(EducationUser educationUserToUpdate);

        /// <summary>
        /// Updates the specified EducationUser using PATCH.
        /// </summary>
        /// <param name="educationUserToUpdate">The EducationUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationUser.</returns>
        System.Threading.Tasks.Task<EducationUser> UpdateAsync(EducationUser educationUserToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationUserRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationUserRequest Expand(Expression<Func<EducationUser, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationUserRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationUserRequest Select(Expression<Func<EducationUser, object>> selectExpression);

    }
}
