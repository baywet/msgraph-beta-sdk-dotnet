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
    /// The type Post.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Post : OutlookItem
    {
    
		///<summary>
		/// The Post constructor
		///</summary>
        public Post()
        {
            this.ODataType = "microsoft.graph.post";
        }
	
        /// <summary>
        /// Gets or sets body.
        /// The contents of the post. This is a default property. This property can be null.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "body", Required = Newtonsoft.Json.Required.Default)]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets received date time.
        /// Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "receivedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ReceivedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// Indicates whether the post has at least one attachment. This is a default property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// Used in delegate access scenarios. Indicates who posted the message on behalf of another user. This is a default property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "from", Required = Newtonsoft.Json.Required.Default)]
        public Recipient From { get; set; }
    
        /// <summary>
        /// Gets or sets sender.
        /// Contains the address of the sender. The value of Sender is assumed to be the address of the authenticated user in the case when Sender is not specified. This is a default property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sender", Required = Newtonsoft.Json.Required.Default)]
        public Recipient Sender { get; set; }
    
        /// <summary>
        /// Gets or sets conversation thread id.
        /// Unique ID of the conversation thread. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conversationThreadId", Required = Newtonsoft.Json.Required.Default)]
        public string ConversationThreadId { get; set; }
    
        /// <summary>
        /// Gets or sets new participants.
        /// Conversation participants that were added to the thread as part of this post.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "newParticipants", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Recipient> NewParticipants { get; set; }
    
        /// <summary>
        /// Gets or sets conversation id.
        /// Unique ID of the conversation. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conversationId", Required = Newtonsoft.Json.Required.Default)]
        public string ConversationId { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importance", Required = Newtonsoft.Json.Required.Default)]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets in reply to.
        /// Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inReplyTo", Required = Newtonsoft.Json.Required.Default)]
        public Post InReplyTo { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the post. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IPostSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the post. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IPostMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the post. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IPostExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attachments", Required = Newtonsoft.Json.Required.Default)]
        public IPostAttachmentsCollectionPage Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets mentions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mentions", Required = Newtonsoft.Json.Required.Default)]
        public IPostMentionsCollectionPage Mentions { get; set; }
    
    }
}

