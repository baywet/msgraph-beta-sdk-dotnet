// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type OrganizationRequestBuilder.
    /// </summary>
    public partial class OrganizationRequestBuilder : DirectoryObjectRequestBuilder, IOrganizationRequestBuilder
    {

        /// <summary>
        /// Constructs a new OrganizationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OrganizationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOrganizationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOrganizationRequest Request(IEnumerable<Option> options)
        {
            return new OrganizationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Brandings.
        /// </summary>
        /// <returns>The <see cref="IOrganizationBrandingsCollectionRequestBuilder"/>.</returns>
        public IOrganizationBrandingsCollectionRequestBuilder Brandings
        {
            get
            {
                return new OrganizationBrandingsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("brandings"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CertificateBasedAuthConfiguration.
        /// </summary>
        /// <returns>The <see cref="IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequestBuilder"/>.</returns>
        public IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequestBuilder CertificateBasedAuthConfiguration
        {
            get
            {
                return new OrganizationCertificateBasedAuthConfigurationCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("certificateBasedAuthConfiguration"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IOrganizationExtensionsCollectionRequestBuilder"/>.</returns>
        public IOrganizationExtensionsCollectionRequestBuilder Extensions
        {
            get
            {
                return new OrganizationExtensionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IOrganizationSettingsRequestBuilder"/>.</returns>
        public IOrganizationSettingsRequestBuilder Settings
        {
            get
            {
                return new OrganizationSettingsRequestBuilder(this.AppendSegmentToRequestUrl("settings"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for OrganizationSetMobileDeviceManagementAuthority.
        /// </summary>
        /// <returns>The <see cref="IOrganizationSetMobileDeviceManagementAuthorityRequestBuilder"/>.</returns>
        public IOrganizationSetMobileDeviceManagementAuthorityRequestBuilder SetMobileDeviceManagementAuthority()
        {
            return new OrganizationSetMobileDeviceManagementAuthorityRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setMobileDeviceManagementAuthority"),
                this.Client);
        }
    
    }
}
