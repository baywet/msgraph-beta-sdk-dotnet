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
    /// The type Windows Update For Business Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsUpdateForBusinessConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The WindowsUpdateForBusinessConfiguration constructor
		///</summary>
        public WindowsUpdateForBusinessConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsUpdateForBusinessConfiguration";
        }
	
        /// <summary>
        /// Gets or sets delivery optimization mode.
        /// Delivery Optimization Mode. Possible values are: userDefined, httpOnly, httpWithPeeringNat, httpWithPeeringPrivateGroup, httpWithInternetPeering, simpleDownload, bypassMode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deliveryOptimizationMode", Required = Newtonsoft.Json.Required.Default)]
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode { get; set; }
    
        /// <summary>
        /// Gets or sets prerelease features.
        /// The pre-release features. Possible values are: userDefined, settingsOnly, settingsAndExperimentations, notAllowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prereleaseFeatures", Required = Newtonsoft.Json.Required.Default)]
        public PrereleaseFeatures? PrereleaseFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets automatic update mode.
        /// Automatic update mode. Possible values are: userDefined, notifyDownload, autoInstallAtMaintenanceTime, autoInstallAndRebootAtMaintenanceTime, autoInstallAndRebootAtScheduledTime, autoInstallAndRebootWithoutEndUserControl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "automaticUpdateMode", Required = Newtonsoft.Json.Required.Default)]
        public AutomaticUpdateMode? AutomaticUpdateMode { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft update service allowed.
        /// Allow Microsoft Update Service
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftUpdateServiceAllowed", Required = Newtonsoft.Json.Required.Default)]
        public bool? MicrosoftUpdateServiceAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets drivers excluded.
        /// Exclude Windows update Drivers
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "driversExcluded", Required = Newtonsoft.Json.Required.Default)]
        public bool? DriversExcluded { get; set; }
    
        /// <summary>
        /// Gets or sets installation schedule.
        /// Installation schedule
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installationSchedule", Required = Newtonsoft.Json.Required.Default)]
        public WindowsUpdateInstallScheduleType InstallationSchedule { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates deferral period in days.
        /// Defer Quality Updates by these many days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualityUpdatesDeferralPeriodInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? QualityUpdatesDeferralPeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates deferral period in days.
        /// Defer Feature Updates by these many days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdatesDeferralPeriodInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FeatureUpdatesDeferralPeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates paused.
        /// Pause Quality Updates
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualityUpdatesPaused", Required = Newtonsoft.Json.Required.Default)]
        public bool? QualityUpdatesPaused { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates paused.
        /// Pause Feature Updates
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdatesPaused", Required = Newtonsoft.Json.Required.Default)]
        public bool? FeatureUpdatesPaused { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates pause expiry date time.
        /// Quality Updates Pause Expiry datetime
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualityUpdatesPauseExpiryDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? QualityUpdatesPauseExpiryDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates pause expiry date time.
        /// Feature Updates Pause Expiry datetime
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdatesPauseExpiryDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? FeatureUpdatesPauseExpiryDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets business ready updates only.
        /// Determines which branch devices will receive their updates from. Possible values are: userDefined, all, businessReadyOnly, windowsInsiderBuildFast, windowsInsiderBuildSlow, windowsInsiderBuildRelease.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessReadyUpdatesOnly", Required = Newtonsoft.Json.Required.Default)]
        public WindowsUpdateType? BusinessReadyUpdatesOnly { get; set; }
    
        /// <summary>
        /// Gets or sets skip checks before restart.
        /// Set to skip all check before restart: Battery level = 40%, User presence, Display Needed, Presentation mode, Full screen mode, phone call state, game mode etc. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skipChecksBeforeRestart", Required = Newtonsoft.Json.Required.Default)]
        public bool? SkipChecksBeforeRestart { get; set; }
    
        /// <summary>
        /// Gets or sets update weeks.
        /// Scheduled the update installation on the weeks of the month
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updateWeeks", Required = Newtonsoft.Json.Required.Default)]
        public WindowsUpdateForBusinessUpdateWeeks? UpdateWeeks { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates pause start date.
        /// Quality Updates Pause start date. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualityUpdatesPauseStartDate", Required = Newtonsoft.Json.Required.Default)]
        public Date QualityUpdatesPauseStartDate { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates pause start date.
        /// Feature Updates Pause start date. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdatesPauseStartDate", Required = Newtonsoft.Json.Required.Default)]
        public Date FeatureUpdatesPauseStartDate { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates rollback window in days.
        /// The number of days after a Feature Update for which a rollback is valid
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdatesRollbackWindowInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FeatureUpdatesRollbackWindowInDays { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates will be rolled back.
        /// Specifies whether to rollback Quality Updates on the next device check in
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualityUpdatesWillBeRolledBack", Required = Newtonsoft.Json.Required.Default)]
        public bool? QualityUpdatesWillBeRolledBack { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates will be rolled back.
        /// Specifies whether to rollback Feature Updates on the next device check in
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdatesWillBeRolledBack", Required = Newtonsoft.Json.Required.Default)]
        public bool? FeatureUpdatesWillBeRolledBack { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates rollback start date time.
        /// Quality Updates Rollback Start datetime
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualityUpdatesRollbackStartDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? QualityUpdatesRollbackStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates rollback start date time.
        /// Feature Updates Rollback Start datetime
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdatesRollbackStartDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? FeatureUpdatesRollbackStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets engaged restart deadline in days.
        /// Deadline in days before automatically scheduling and executing a pending restart outside of active hours, with valid range from 2 to 30 days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "engagedRestartDeadlineInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EngagedRestartDeadlineInDays { get; set; }
    
        /// <summary>
        /// Gets or sets engaged restart snooze schedule in days.
        /// Number of days a user can snooze Engaged Restart reminder notifications with valid range from 1 to 3 days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "engagedRestartSnoozeScheduleInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EngagedRestartSnoozeScheduleInDays { get; set; }
    
        /// <summary>
        /// Gets or sets engaged restart transition schedule in days.
        /// Number of days before transitioning from Auto Restarts scheduled outside of active hours to Engaged Restart, which requires the user to schedule, with valid range from 0 to 30 days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "engagedRestartTransitionScheduleInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EngagedRestartTransitionScheduleInDays { get; set; }
    
        /// <summary>
        /// Gets or sets deadline for feature updates in days.
        /// Number of days before feature updates are installed automatically with valid range from 2 to 30 days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deadlineForFeatureUpdatesInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeadlineForFeatureUpdatesInDays { get; set; }
    
        /// <summary>
        /// Gets or sets deadline for quality updates in days.
        /// Number of days before quality updates are installed automatically with valid range from 2 to 30 days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deadlineForQualityUpdatesInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeadlineForQualityUpdatesInDays { get; set; }
    
        /// <summary>
        /// Gets or sets deadline grace period in days.
        /// Number of days after deadline  until restarts occur automatically with valid range from 0 to 7 days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deadlineGracePeriodInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeadlineGracePeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets postpone reboot until after deadline.
        /// Specifies if the device should wait until deadline for rebooting outside of active hours
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postponeRebootUntilAfterDeadline", Required = Newtonsoft.Json.Required.Default)]
        public bool? PostponeRebootUntilAfterDeadline { get; set; }
    
        /// <summary>
        /// Gets or sets auto restart notification dismissal.
        /// Specify the method by which the auto-restart required notification is dismissed
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "autoRestartNotificationDismissal", Required = Newtonsoft.Json.Required.Default)]
        public AutoRestartNotificationDismissalMethod? AutoRestartNotificationDismissal { get; set; }
    
        /// <summary>
        /// Gets or sets schedule restart warning in hours.
        /// Specify the period for auto-restart warning reminder notifications. Supported values: 2, 4, 8, 12 or 24 (hours).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduleRestartWarningInHours", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ScheduleRestartWarningInHours { get; set; }
    
        /// <summary>
        /// Gets or sets schedule imminent restart warning in minutes.
        /// Specify the period for auto-restart imminent warning notifications. Supported values: 15, 30 or 60 (minutes).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduleImminentRestartWarningInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ScheduleImminentRestartWarningInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets user pause access.
        /// Specifies whether to enable end userâ€™s access to pause software updates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPauseAccess", Required = Newtonsoft.Json.Required.Default)]
        public Enablement? UserPauseAccess { get; set; }
    
        /// <summary>
        /// Gets or sets user windows update scan access.
        /// Specifies whether to disable userâ€™s access to scan Windows Update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userWindowsUpdateScanAccess", Required = Newtonsoft.Json.Required.Default)]
        public Enablement? UserWindowsUpdateScanAccess { get; set; }
    
        /// <summary>
        /// Gets or sets update notification level.
        /// Specifies what Windows Update notifications users see.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updateNotificationLevel", Required = Newtonsoft.Json.Required.Default)]
        public WindowsUpdateNotificationDisplayOption? UpdateNotificationLevel { get; set; }
    
        /// <summary>
        /// Gets or sets device update states.
        /// Windows update for business configuration device states.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceUpdateStates", Required = Newtonsoft.Json.Required.Default)]
        public IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionPage DeviceUpdateStates { get; set; }
    
    }
}

