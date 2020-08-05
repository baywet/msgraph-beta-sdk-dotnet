// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DataType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DataType
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Boolean
        /// </summary>
        Boolean = 1,
	
        /// <summary>
        /// Int64
        /// </summary>
        Int64 = 2,
	
        /// <summary>
        /// Double
        /// </summary>
        Double = 3,
	
        /// <summary>
        /// String
        /// </summary>
        @String = 4,
	
        /// <summary>
        /// Date Time
        /// </summary>
        DateTime = 5,
	
        /// <summary>
        /// Version
        /// </summary>
        Version = 6,
	
        /// <summary>
        /// Base64
        /// </summary>
        Base64 = 7,
	
        /// <summary>
        /// Xml
        /// </summary>
        Xml = 8,
	
        /// <summary>
        /// Boolean Array
        /// </summary>
        BooleanArray = 9,
	
        /// <summary>
        /// Int64Array
        /// </summary>
        Int64Array = 10,
	
        /// <summary>
        /// Double Array
        /// </summary>
        DoubleArray = 11,
	
        /// <summary>
        /// String Array
        /// </summary>
        StringArray = 12,
	
        /// <summary>
        /// Date Time Array
        /// </summary>
        DateTimeArray = 13,
	
        /// <summary>
        /// Version Array
        /// </summary>
        VersionArray = 14,
	
    }
}
