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
    /// The type Education Class.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationClass : Entity
    {
    
		///<summary>
		/// The EducationClass constructor
		///</summary>
        public EducationClass()
        {
            this.ODataType = "microsoft.graph.educationClass";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// Name of the class.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// Mail name for sending email to all members, if this is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailNickname", Required = Newtonsoft.Json.Required.Default)]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the class.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Entity who created the class
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets class code.
        /// Class code used by the school to identify the class.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classCode", Required = Newtonsoft.Json.Required.Default)]
        public string ClassCode { get; set; }
    
        /// <summary>
        /// Gets or sets external name.
        /// Name of the class in the syncing system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalName", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalName { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// ID of the class from the syncing system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalId", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets external source.
        /// How this class was created. The possible values are: sis, manual, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalSource", Required = Newtonsoft.Json.Required.Default)]
        public EducationExternalSource? ExternalSource { get; set; }
    
        /// <summary>
        /// Gets or sets grade.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "grade", Required = Newtonsoft.Json.Required.Default)]
        public string Grade { get; set; }
    
        /// <summary>
        /// Gets or sets term.
        /// Term for this class.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "term", Required = Newtonsoft.Json.Required.Default)]
        public EducationTerm Term { get; set; }
    
        /// <summary>
        /// Gets or sets course.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "course", Required = Newtonsoft.Json.Required.Default)]
        public EducationCourse Course { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IEducationClassAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets assignment categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignmentCategories", Required = Newtonsoft.Json.Required.Default)]
        public IEducationClassAssignmentCategoriesCollectionPage AssignmentCategories { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// All users in the class. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public IEducationClassMembersCollectionWithReferencesPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets teachers.
        /// All teachers in the class. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teachers", Required = Newtonsoft.Json.Required.Default)]
        public IEducationClassTeachersCollectionWithReferencesPage Teachers { get; set; }
    
        /// <summary>
        /// Gets or sets schools.
        /// All schools that this class is associated with. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schools", Required = Newtonsoft.Json.Required.Default)]
        public IEducationClassSchoolsCollectionWithReferencesPage Schools { get; set; }
    
        /// <summary>
        /// Gets or sets group.
        /// The directory group corresponding to this class.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "group", Required = Newtonsoft.Json.Required.Default)]
        public Group Group { get; set; }
    
    }
}

