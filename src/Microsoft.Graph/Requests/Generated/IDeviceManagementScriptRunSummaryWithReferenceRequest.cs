// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementScriptRunSummaryWithReferenceRequest.
    /// </summary>
    public partial interface IDeviceManagementScriptRunSummaryWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified DeviceManagementScriptRunSummary.
        /// </summary>
        /// <returns>The DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementScriptRunSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified DeviceManagementScriptRunSummary using POST.
        /// </summary>
        /// <param name="deviceManagementScriptRunSummaryToCreate">The DeviceManagementScriptRunSummary to create.</param>
        /// <returns>The created DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> CreateAsync(DeviceManagementScriptRunSummary deviceManagementScriptRunSummaryToCreate);        /// <summary>
        /// Creates the specified DeviceManagementScriptRunSummary using POST.
        /// </summary>
        /// <param name="deviceManagementScriptRunSummaryToCreate">The DeviceManagementScriptRunSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> CreateAsync(DeviceManagementScriptRunSummary deviceManagementScriptRunSummaryToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified DeviceManagementScriptRunSummary using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptRunSummaryToUpdate">The DeviceManagementScriptRunSummary to update.</param>
        /// <returns>The updated DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> UpdateAsync(DeviceManagementScriptRunSummary deviceManagementScriptRunSummaryToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementScriptRunSummary using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptRunSummaryToUpdate">The DeviceManagementScriptRunSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> UpdateAsync(DeviceManagementScriptRunSummary deviceManagementScriptRunSummaryToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified DeviceManagementScriptRunSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementScriptRunSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequest Expand(Expression<Func<DeviceManagementScriptRunSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequest Select(Expression<Func<DeviceManagementScriptRunSummary, object>> selectExpression);

    }
}
