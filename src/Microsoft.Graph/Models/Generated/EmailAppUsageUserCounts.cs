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
    /// The type Email App Usage User Counts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EmailAppUsageUserCounts : Entity
    {
    
		///<summary>
		/// The EmailAppUsageUserCounts constructor
		///</summary>
        public EmailAppUsageUserCounts()
        {
            this.ODataType = "microsoft.graph.emailAppUsageUserCounts";
        }
	
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets mail for mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailForMac", Required = Newtonsoft.Json.Required.Default)]
        public Int64? MailForMac { get; set; }
    
        /// <summary>
        /// Gets or sets outlook for mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForMac", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutlookForMac { get; set; }
    
        /// <summary>
        /// Gets or sets outlook for windows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForWindows", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutlookForWindows { get; set; }
    
        /// <summary>
        /// Gets or sets outlook for mobile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForMobile", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutlookForMobile { get; set; }
    
        /// <summary>
        /// Gets or sets other for mobile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "otherForMobile", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OtherForMobile { get; set; }
    
        /// <summary>
        /// Gets or sets outlook for web.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlookForWeb", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutlookForWeb { get; set; }
    
        /// <summary>
        /// Gets or sets pop3app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pop3App", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Pop3App { get; set; }
    
        /// <summary>
        /// Gets or sets imap4app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imap4App", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Imap4App { get; set; }
    
        /// <summary>
        /// Gets or sets smtp app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smtpApp", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SmtpApp { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}

