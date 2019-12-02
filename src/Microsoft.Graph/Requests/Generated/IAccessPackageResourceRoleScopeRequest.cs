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
    /// The interface IAccessPackageResourceRoleScopeRequest.
    /// </summary>
    public partial interface IAccessPackageResourceRoleScopeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessPackageResourceRoleScope using POST.
        /// </summary>
        /// <param name="accessPackageResourceRoleScopeToCreate">The AccessPackageResourceRoleScope to create.</param>
        /// <returns>The created AccessPackageResourceRoleScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceRoleScope> CreateAsync(AccessPackageResourceRoleScope accessPackageResourceRoleScopeToCreate);        /// <summary>
        /// Creates the specified AccessPackageResourceRoleScope using POST.
        /// </summary>
        /// <param name="accessPackageResourceRoleScopeToCreate">The AccessPackageResourceRoleScope to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageResourceRoleScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceRoleScope> CreateAsync(AccessPackageResourceRoleScope accessPackageResourceRoleScopeToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AccessPackageResourceRoleScope.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AccessPackageResourceRoleScope.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AccessPackageResourceRoleScope.
        /// </summary>
        /// <returns>The AccessPackageResourceRoleScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceRoleScope> GetAsync();

        /// <summary>
        /// Gets the specified AccessPackageResourceRoleScope.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageResourceRoleScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceRoleScope> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AccessPackageResourceRoleScope using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceRoleScopeToUpdate">The AccessPackageResourceRoleScope to update.</param>
        /// <returns>The updated AccessPackageResourceRoleScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceRoleScope> UpdateAsync(AccessPackageResourceRoleScope accessPackageResourceRoleScopeToUpdate);

        /// <summary>
        /// Updates the specified AccessPackageResourceRoleScope using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceRoleScopeToUpdate">The AccessPackageResourceRoleScope to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageResourceRoleScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceRoleScope> UpdateAsync(AccessPackageResourceRoleScope accessPackageResourceRoleScopeToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceRoleScopeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceRoleScopeRequest Expand(Expression<Func<AccessPackageResourceRoleScope, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceRoleScopeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceRoleScopeRequest Select(Expression<Func<AccessPackageResourceRoleScope, object>> selectExpression);

    }
}
