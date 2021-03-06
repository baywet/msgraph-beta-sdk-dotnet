// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindowsAssignedAccessProfileRequest.
    /// </summary>
    public partial interface IWindowsAssignedAccessProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsAssignedAccessProfile using POST.
        /// </summary>
        /// <param name="windowsAssignedAccessProfileToCreate">The WindowsAssignedAccessProfile to create.</param>
        /// <returns>The created WindowsAssignedAccessProfile.</returns>
        System.Threading.Tasks.Task<WindowsAssignedAccessProfile> CreateAsync(WindowsAssignedAccessProfile windowsAssignedAccessProfileToCreate);        /// <summary>
        /// Creates the specified WindowsAssignedAccessProfile using POST.
        /// </summary>
        /// <param name="windowsAssignedAccessProfileToCreate">The WindowsAssignedAccessProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsAssignedAccessProfile.</returns>
        System.Threading.Tasks.Task<WindowsAssignedAccessProfile> CreateAsync(WindowsAssignedAccessProfile windowsAssignedAccessProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsAssignedAccessProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsAssignedAccessProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsAssignedAccessProfile.
        /// </summary>
        /// <returns>The WindowsAssignedAccessProfile.</returns>
        System.Threading.Tasks.Task<WindowsAssignedAccessProfile> GetAsync();

        /// <summary>
        /// Gets the specified WindowsAssignedAccessProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsAssignedAccessProfile.</returns>
        System.Threading.Tasks.Task<WindowsAssignedAccessProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsAssignedAccessProfile using PATCH.
        /// </summary>
        /// <param name="windowsAssignedAccessProfileToUpdate">The WindowsAssignedAccessProfile to update.</param>
        /// <returns>The updated WindowsAssignedAccessProfile.</returns>
        System.Threading.Tasks.Task<WindowsAssignedAccessProfile> UpdateAsync(WindowsAssignedAccessProfile windowsAssignedAccessProfileToUpdate);

        /// <summary>
        /// Updates the specified WindowsAssignedAccessProfile using PATCH.
        /// </summary>
        /// <param name="windowsAssignedAccessProfileToUpdate">The WindowsAssignedAccessProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsAssignedAccessProfile.</returns>
        System.Threading.Tasks.Task<WindowsAssignedAccessProfile> UpdateAsync(WindowsAssignedAccessProfile windowsAssignedAccessProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAssignedAccessProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAssignedAccessProfileRequest Expand(Expression<Func<WindowsAssignedAccessProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAssignedAccessProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAssignedAccessProfileRequest Select(Expression<Func<WindowsAssignedAccessProfile, object>> selectExpression);

    }
}
