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
    /// The interface IMacOSTrustedRootCertificateRequest.
    /// </summary>
    public partial interface IMacOSTrustedRootCertificateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="macOSTrustedRootCertificateToCreate">The MacOSTrustedRootCertificate to create.</param>
        /// <returns>The created MacOSTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<MacOSTrustedRootCertificate> CreateAsync(MacOSTrustedRootCertificate macOSTrustedRootCertificateToCreate);        /// <summary>
        /// Creates the specified MacOSTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="macOSTrustedRootCertificateToCreate">The MacOSTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<MacOSTrustedRootCertificate> CreateAsync(MacOSTrustedRootCertificate macOSTrustedRootCertificateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSTrustedRootCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSTrustedRootCertificate.
        /// </summary>
        /// <returns>The MacOSTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<MacOSTrustedRootCertificate> GetAsync();

        /// <summary>
        /// Gets the specified MacOSTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<MacOSTrustedRootCertificate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="macOSTrustedRootCertificateToUpdate">The MacOSTrustedRootCertificate to update.</param>
        /// <returns>The updated MacOSTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<MacOSTrustedRootCertificate> UpdateAsync(MacOSTrustedRootCertificate macOSTrustedRootCertificateToUpdate);

        /// <summary>
        /// Updates the specified MacOSTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="macOSTrustedRootCertificateToUpdate">The MacOSTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<MacOSTrustedRootCertificate> UpdateAsync(MacOSTrustedRootCertificate macOSTrustedRootCertificateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSTrustedRootCertificateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSTrustedRootCertificateRequest Expand(Expression<Func<MacOSTrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSTrustedRootCertificateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSTrustedRootCertificateRequest Select(Expression<Func<MacOSTrustedRootCertificate, object>> selectExpression);

    }
}
