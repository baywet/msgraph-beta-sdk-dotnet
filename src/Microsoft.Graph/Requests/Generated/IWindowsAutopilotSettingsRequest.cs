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
    /// The interface IWindowsAutopilotSettingsRequest.
    /// </summary>
    public partial interface IWindowsAutopilotSettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsAutopilotSettings using POST.
        /// </summary>
        /// <param name="windowsAutopilotSettingsToCreate">The WindowsAutopilotSettings to create.</param>
        /// <returns>The created WindowsAutopilotSettings.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotSettings> CreateAsync(WindowsAutopilotSettings windowsAutopilotSettingsToCreate);        /// <summary>
        /// Creates the specified WindowsAutopilotSettings using POST.
        /// </summary>
        /// <param name="windowsAutopilotSettingsToCreate">The WindowsAutopilotSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsAutopilotSettings.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotSettings> CreateAsync(WindowsAutopilotSettings windowsAutopilotSettingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsAutopilotSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsAutopilotSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsAutopilotSettings.
        /// </summary>
        /// <returns>The WindowsAutopilotSettings.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotSettings> GetAsync();

        /// <summary>
        /// Gets the specified WindowsAutopilotSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsAutopilotSettings.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotSettings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsAutopilotSettings using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotSettingsToUpdate">The WindowsAutopilotSettings to update.</param>
        /// <returns>The updated WindowsAutopilotSettings.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotSettings> UpdateAsync(WindowsAutopilotSettings windowsAutopilotSettingsToUpdate);

        /// <summary>
        /// Updates the specified WindowsAutopilotSettings using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotSettingsToUpdate">The WindowsAutopilotSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsAutopilotSettings.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotSettings> UpdateAsync(WindowsAutopilotSettings windowsAutopilotSettingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotSettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotSettingsRequest Expand(Expression<Func<WindowsAutopilotSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotSettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotSettingsRequest Select(Expression<Func<WindowsAutopilotSettings, object>> selectExpression);

    }
}
