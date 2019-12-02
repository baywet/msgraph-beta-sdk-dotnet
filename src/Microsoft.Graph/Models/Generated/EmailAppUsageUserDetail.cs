// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Email App Usage User Detail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EmailAppUsageUserDetail : Entity
    {
    
		///<summary>
		/// The EmailAppUsageUserDetail constructor
		///</summary>
        public EmailAppUsageUserDetail()
        {
            this.ODataType = "microsoft.graph.emailAppUsageUserDetail";
        }
	
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeleted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets deleted date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deletedDate", Required = Newtonsoft.Json.Required.Default)]
        public Date DeletedDate { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date LastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets mail for mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailForMac", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> MailForMac { get; set; }
    
        /// <summary>
        /// Gets or sets outlook for mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForMac", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> OutlookForMac { get; set; }
    
        /// <summary>
        /// Gets or sets outlook for windows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForWindows", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> OutlookForWindows { get; set; }
    
        /// <summary>
        /// Gets or sets outlook for mobile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForMobile", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> OutlookForMobile { get; set; }
    
        /// <summary>
        /// Gets or sets other for mobile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "otherForMobile", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> OtherForMobile { get; set; }
    
        /// <summary>
        /// Gets or sets outlook for web.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForWeb", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> OutlookForWeb { get; set; }
    
        /// <summary>
        /// Gets or sets pop3app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pop3App", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Pop3App { get; set; }
    
        /// <summary>
        /// Gets or sets imap4app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imap4App", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Imap4App { get; set; }
    
        /// <summary>
        /// Gets or sets smtp app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smtpApp", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SmtpApp { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}

