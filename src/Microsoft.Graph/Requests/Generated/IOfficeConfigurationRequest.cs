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
    /// The interface IOfficeConfigurationRequest.
    /// </summary>
    public partial interface IOfficeConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OfficeConfiguration using POST.
        /// </summary>
        /// <param name="officeConfigurationToCreate">The OfficeConfiguration to create.</param>
        /// <returns>The created OfficeConfiguration.</returns>
        System.Threading.Tasks.Task<OfficeConfiguration> CreateAsync(OfficeConfiguration officeConfigurationToCreate);        /// <summary>
        /// Creates the specified OfficeConfiguration using POST.
        /// </summary>
        /// <param name="officeConfigurationToCreate">The OfficeConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OfficeConfiguration.</returns>
        System.Threading.Tasks.Task<OfficeConfiguration> CreateAsync(OfficeConfiguration officeConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OfficeConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OfficeConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OfficeConfiguration.
        /// </summary>
        /// <returns>The OfficeConfiguration.</returns>
        System.Threading.Tasks.Task<OfficeConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified OfficeConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OfficeConfiguration.</returns>
        System.Threading.Tasks.Task<OfficeConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OfficeConfiguration using PATCH.
        /// </summary>
        /// <param name="officeConfigurationToUpdate">The OfficeConfiguration to update.</param>
        /// <returns>The updated OfficeConfiguration.</returns>
        System.Threading.Tasks.Task<OfficeConfiguration> UpdateAsync(OfficeConfiguration officeConfigurationToUpdate);

        /// <summary>
        /// Updates the specified OfficeConfiguration using PATCH.
        /// </summary>
        /// <param name="officeConfigurationToUpdate">The OfficeConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OfficeConfiguration.</returns>
        System.Threading.Tasks.Task<OfficeConfiguration> UpdateAsync(OfficeConfiguration officeConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeConfigurationRequest Expand(Expression<Func<OfficeConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeConfigurationRequest Select(Expression<Func<OfficeConfiguration, object>> selectExpression);

    }
}
