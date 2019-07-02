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
    /// The enum RemoteAction.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RemoteAction
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Factory Reset
        /// </summary>
        FactoryReset = 1,
	
        /// <summary>
        /// Remove Company Data
        /// </summary>
        RemoveCompanyData = 2,
	
        /// <summary>
        /// Reset Passcode
        /// </summary>
        ResetPasscode = 3,
	
        /// <summary>
        /// Remote Lock
        /// </summary>
        RemoteLock = 4,
	
        /// <summary>
        /// Enable Lost Mode
        /// </summary>
        EnableLostMode = 5,
	
        /// <summary>
        /// Disable Lost Mode
        /// </summary>
        DisableLostMode = 6,
	
        /// <summary>
        /// Locate Device
        /// </summary>
        LocateDevice = 7,
	
        /// <summary>
        /// Reboot Now
        /// </summary>
        RebootNow = 8,
	
        /// <summary>
        /// Recover Passcode
        /// </summary>
        RecoverPasscode = 9,
	
        /// <summary>
        /// Clean Windows Device
        /// </summary>
        CleanWindowsDevice = 10,
	
        /// <summary>
        /// Logout Shared Apple Device Active User
        /// </summary>
        LogoutSharedAppleDeviceActiveUser = 11,
	
        /// <summary>
        /// Quick Scan
        /// </summary>
        QuickScan = 12,
	
        /// <summary>
        /// Full Scan
        /// </summary>
        FullScan = 13,
	
        /// <summary>
        /// Windows Defender Update Signatures
        /// </summary>
        WindowsDefenderUpdateSignatures = 14,
	
        /// <summary>
        /// Factory Reset Keep Enrollment Data
        /// </summary>
        FactoryResetKeepEnrollmentData = 15,
	
        /// <summary>
        /// Update Device Account
        /// </summary>
        UpdateDeviceAccount = 16,
	
        /// <summary>
        /// Automatic Redeployment
        /// </summary>
        AutomaticRedeployment = 17,
	
        /// <summary>
        /// Shut Down
        /// </summary>
        ShutDown = 18,
	
        /// <summary>
        /// Rotate File Vault Key
        /// </summary>
        RotateFileVaultKey = 20,
	
        /// <summary>
        /// Get File Vault Key
        /// </summary>
        GetFileVaultKey = 21,
	
    }
}
