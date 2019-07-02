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
    /// The interface IGovernanceRoleDefinitionRequest.
    /// </summary>
    public partial interface IGovernanceRoleDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GovernanceRoleDefinition using POST.
        /// </summary>
        /// <param name="governanceRoleDefinitionToCreate">The GovernanceRoleDefinition to create.</param>
        /// <returns>The created GovernanceRoleDefinition.</returns>
        System.Threading.Tasks.Task<GovernanceRoleDefinition> CreateAsync(GovernanceRoleDefinition governanceRoleDefinitionToCreate);        /// <summary>
        /// Creates the specified GovernanceRoleDefinition using POST.
        /// </summary>
        /// <param name="governanceRoleDefinitionToCreate">The GovernanceRoleDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceRoleDefinition.</returns>
        System.Threading.Tasks.Task<GovernanceRoleDefinition> CreateAsync(GovernanceRoleDefinition governanceRoleDefinitionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GovernanceRoleDefinition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GovernanceRoleDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GovernanceRoleDefinition.
        /// </summary>
        /// <returns>The GovernanceRoleDefinition.</returns>
        System.Threading.Tasks.Task<GovernanceRoleDefinition> GetAsync();

        /// <summary>
        /// Gets the specified GovernanceRoleDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceRoleDefinition.</returns>
        System.Threading.Tasks.Task<GovernanceRoleDefinition> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GovernanceRoleDefinition using PATCH.
        /// </summary>
        /// <param name="governanceRoleDefinitionToUpdate">The GovernanceRoleDefinition to update.</param>
        /// <returns>The updated GovernanceRoleDefinition.</returns>
        System.Threading.Tasks.Task<GovernanceRoleDefinition> UpdateAsync(GovernanceRoleDefinition governanceRoleDefinitionToUpdate);

        /// <summary>
        /// Updates the specified GovernanceRoleDefinition using PATCH.
        /// </summary>
        /// <param name="governanceRoleDefinitionToUpdate">The GovernanceRoleDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernanceRoleDefinition.</returns>
        System.Threading.Tasks.Task<GovernanceRoleDefinition> UpdateAsync(GovernanceRoleDefinition governanceRoleDefinitionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleDefinitionRequest Expand(Expression<Func<GovernanceRoleDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleDefinitionRequest Select(Expression<Func<GovernanceRoleDefinition, object>> selectExpression);

    }
}
