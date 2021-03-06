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
    /// The interface IDeviceManagementScriptGroupAssignmentRequest.
    /// </summary>
    public partial interface IDeviceManagementScriptGroupAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementScriptGroupAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementScriptGroupAssignmentToCreate">The DeviceManagementScriptGroupAssignment to create.</param>
        /// <returns>The created DeviceManagementScriptGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptGroupAssignment> CreateAsync(DeviceManagementScriptGroupAssignment deviceManagementScriptGroupAssignmentToCreate);        /// <summary>
        /// Creates the specified DeviceManagementScriptGroupAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementScriptGroupAssignmentToCreate">The DeviceManagementScriptGroupAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScriptGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptGroupAssignment> CreateAsync(DeviceManagementScriptGroupAssignment deviceManagementScriptGroupAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementScriptGroupAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementScriptGroupAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementScriptGroupAssignment.
        /// </summary>
        /// <returns>The DeviceManagementScriptGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptGroupAssignment> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementScriptGroupAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScriptGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptGroupAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementScriptGroupAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptGroupAssignmentToUpdate">The DeviceManagementScriptGroupAssignment to update.</param>
        /// <returns>The updated DeviceManagementScriptGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptGroupAssignment> UpdateAsync(DeviceManagementScriptGroupAssignment deviceManagementScriptGroupAssignmentToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementScriptGroupAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptGroupAssignmentToUpdate">The DeviceManagementScriptGroupAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScriptGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptGroupAssignment> UpdateAsync(DeviceManagementScriptGroupAssignment deviceManagementScriptGroupAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptGroupAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptGroupAssignmentRequest Expand(Expression<Func<DeviceManagementScriptGroupAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptGroupAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptGroupAssignmentRequest Select(Expression<Func<DeviceManagementScriptGroupAssignment, object>> selectExpression);

    }
}
