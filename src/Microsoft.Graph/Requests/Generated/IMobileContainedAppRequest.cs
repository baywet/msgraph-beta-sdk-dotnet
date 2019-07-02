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
    /// The interface IMobileContainedAppRequest.
    /// </summary>
    public partial interface IMobileContainedAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MobileContainedApp using POST.
        /// </summary>
        /// <param name="mobileContainedAppToCreate">The MobileContainedApp to create.</param>
        /// <returns>The created MobileContainedApp.</returns>
        System.Threading.Tasks.Task<MobileContainedApp> CreateAsync(MobileContainedApp mobileContainedAppToCreate);        /// <summary>
        /// Creates the specified MobileContainedApp using POST.
        /// </summary>
        /// <param name="mobileContainedAppToCreate">The MobileContainedApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileContainedApp.</returns>
        System.Threading.Tasks.Task<MobileContainedApp> CreateAsync(MobileContainedApp mobileContainedAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MobileContainedApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MobileContainedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MobileContainedApp.
        /// </summary>
        /// <returns>The MobileContainedApp.</returns>
        System.Threading.Tasks.Task<MobileContainedApp> GetAsync();

        /// <summary>
        /// Gets the specified MobileContainedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileContainedApp.</returns>
        System.Threading.Tasks.Task<MobileContainedApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MobileContainedApp using PATCH.
        /// </summary>
        /// <param name="mobileContainedAppToUpdate">The MobileContainedApp to update.</param>
        /// <returns>The updated MobileContainedApp.</returns>
        System.Threading.Tasks.Task<MobileContainedApp> UpdateAsync(MobileContainedApp mobileContainedAppToUpdate);

        /// <summary>
        /// Updates the specified MobileContainedApp using PATCH.
        /// </summary>
        /// <param name="mobileContainedAppToUpdate">The MobileContainedApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileContainedApp.</returns>
        System.Threading.Tasks.Task<MobileContainedApp> UpdateAsync(MobileContainedApp mobileContainedAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileContainedAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileContainedAppRequest Expand(Expression<Func<MobileContainedApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileContainedAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileContainedAppRequest Select(Expression<Func<MobileContainedApp, object>> selectExpression);

    }
}
