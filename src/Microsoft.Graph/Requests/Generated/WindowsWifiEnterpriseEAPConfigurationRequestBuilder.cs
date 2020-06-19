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
    /// The type WindowsWifiEnterpriseEAPConfigurationRequestBuilder.
    /// </summary>
    public partial class WindowsWifiEnterpriseEAPConfigurationRequestBuilder : WindowsWifiConfigurationRequestBuilder, IWindowsWifiEnterpriseEAPConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsWifiEnterpriseEAPConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsWifiEnterpriseEAPConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWindowsWifiEnterpriseEAPConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWindowsWifiEnterpriseEAPConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new WindowsWifiEnterpriseEAPConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RootCertificatesForServerValidation.
        /// </summary>
        /// <returns>The <see cref="IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionRequestBuilder"/>.</returns>
        public IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionRequestBuilder RootCertificatesForServerValidation
        {
            get
            {
                return new WindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionRequestBuilder(this.AppendSegmentToRequestUrl("rootCertificatesForServerValidation"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IdentityCertificateForClientAuthentication.
        /// </summary>
        /// <returns>The <see cref="IWindowsCertificateProfileBaseWithReferenceRequestBuilder"/>.</returns>
        public IWindowsCertificateProfileBaseWithReferenceRequestBuilder IdentityCertificateForClientAuthentication
        {
            get
            {
                return new WindowsCertificateProfileBaseWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("identityCertificateForClientAuthentication"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RootCertificateForClientValidation.
        /// </summary>
        /// <returns>The <see cref="IWindows81TrustedRootCertificateWithReferenceRequestBuilder"/>.</returns>
        public IWindows81TrustedRootCertificateWithReferenceRequestBuilder RootCertificateForClientValidation
        {
            get
            {
                return new Windows81TrustedRootCertificateWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("rootCertificateForClientValidation"), this.Client);
            }
        }
    
    }
}
