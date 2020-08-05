// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Win32LobAppFileSystemRule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Win32LobAppFileSystemRule : Win32LobAppRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppFileSystemRule"/> class.
        /// </summary>
        public Win32LobAppFileSystemRule()
        {
            this.ODataType = "microsoft.graph.win32LobAppFileSystemRule";
        }

        /// <summary>
        /// Gets or sets path.
        /// The file or folder path to look up.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "path", Required = Newtonsoft.Json.Required.Default)]
        public string Path { get; set; }
    
        /// <summary>
        /// Gets or sets fileOrFolderName.
        /// The file or folder name to look up.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileOrFolderName", Required = Newtonsoft.Json.Required.Default)]
        public string FileOrFolderName { get; set; }
    
        /// <summary>
        /// Gets or sets check32BitOn64System.
        /// A value indicating whether to expand environment variables in the 32-bit context on 64-bit systems.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "check32BitOn64System", Required = Newtonsoft.Json.Required.Default)]
        public bool? Check32BitOn64System { get; set; }
    
        /// <summary>
        /// Gets or sets operationType.
        /// The file system operation type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operationType", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppFileSystemOperationType? OperationType { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// The operator for file or folder detection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operator", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppRuleOperator? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets comparisonValue.
        /// The file or folder comparison value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comparisonValue", Required = Newtonsoft.Json.Required.Default)]
        public string ComparisonValue { get; set; }
    
    }
}
