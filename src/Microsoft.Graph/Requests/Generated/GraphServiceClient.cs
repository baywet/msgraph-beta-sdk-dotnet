// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityClient.cs.tt

namespace Microsoft.Graph
{

    /// <summary>
    /// The type GraphServiceClient.
    /// </summary>
    public partial class GraphServiceClient : BaseClient, IGraphServiceClient
    {
        /// <summary>
        /// Instantiates a new GraphServiceClient.
        /// </summary>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public GraphServiceClient(
            IAuthenticationProvider authenticationProvider,
            IHttpProvider httpProvider = null)
            : this("https://graph.microsoft.com/beta", authenticationProvider, httpProvider)
        {
        }

        /// <summary>
        /// Instantiates a new GraphServiceClient.
        /// </summary>
        /// <param name="baseUrl">The base service URL. For example, "https://graph.microsoft.com/beta".</param>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public GraphServiceClient(
            string baseUrl,
            IAuthenticationProvider authenticationProvider,
            IHttpProvider httpProvider = null)
            : base(baseUrl, authenticationProvider, httpProvider)
        {
        }
    
        /// <summary>
        /// Gets the GraphServiceSchemaExtensions request builder.
        /// </summary>
        public IGraphServiceSchemaExtensionsCollectionRequestBuilder SchemaExtensions
        {
            get
            {
                return new GraphServiceSchemaExtensionsCollectionRequestBuilder(this.BaseUrl + "/schemaExtensions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryObjects request builder.
        /// </summary>
        public IGraphServiceDirectoryObjectsCollectionRequestBuilder DirectoryObjects
        {
            get
            {
                return new GraphServiceDirectoryObjectsCollectionRequestBuilder(this.BaseUrl + "/directoryObjects", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceApplications request builder.
        /// </summary>
        public IGraphServiceApplicationsCollectionRequestBuilder Applications
        {
            get
            {
                return new GraphServiceApplicationsCollectionRequestBuilder(this.BaseUrl + "/applications", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAdministrativeUnits request builder.
        /// </summary>
        public IGraphServiceAdministrativeUnitsCollectionRequestBuilder AdministrativeUnits
        {
            get
            {
                return new GraphServiceAdministrativeUnitsCollectionRequestBuilder(this.BaseUrl + "/administrativeUnits", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAllowedDataLocations request builder.
        /// </summary>
        public IGraphServiceAllowedDataLocationsCollectionRequestBuilder AllowedDataLocations
        {
            get
            {
                return new GraphServiceAllowedDataLocationsCollectionRequestBuilder(this.BaseUrl + "/allowedDataLocations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAppRoleAssignments request builder.
        /// </summary>
        public IGraphServiceAppRoleAssignmentsCollectionRequestBuilder AppRoleAssignments
        {
            get
            {
                return new GraphServiceAppRoleAssignmentsCollectionRequestBuilder(this.BaseUrl + "/appRoleAssignments", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceContacts request builder.
        /// </summary>
        public IGraphServiceContactsCollectionRequestBuilder Contacts
        {
            get
            {
                return new GraphServiceContactsCollectionRequestBuilder(this.BaseUrl + "/contacts", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDevices request builder.
        /// </summary>
        public IGraphServiceDevicesCollectionRequestBuilder Devices
        {
            get
            {
                return new GraphServiceDevicesCollectionRequestBuilder(this.BaseUrl + "/devices", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDomains request builder.
        /// </summary>
        public IGraphServiceDomainsCollectionRequestBuilder Domains
        {
            get
            {
                return new GraphServiceDomainsCollectionRequestBuilder(this.BaseUrl + "/domains", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDomainDnsRecords request builder.
        /// </summary>
        public IGraphServiceDomainDnsRecordsCollectionRequestBuilder DomainDnsRecords
        {
            get
            {
                return new GraphServiceDomainDnsRecordsCollectionRequestBuilder(this.BaseUrl + "/domainDnsRecords", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroups request builder.
        /// </summary>
        public IGraphServiceGroupsCollectionRequestBuilder Groups
        {
            get
            {
                return new GraphServiceGroupsCollectionRequestBuilder(this.BaseUrl + "/groups", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoles request builder.
        /// </summary>
        public IGraphServiceDirectoryRolesCollectionRequestBuilder DirectoryRoles
        {
            get
            {
                return new GraphServiceDirectoryRolesCollectionRequestBuilder(this.BaseUrl + "/directoryRoles", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoleTemplates request builder.
        /// </summary>
        public IGraphServiceDirectoryRoleTemplatesCollectionRequestBuilder DirectoryRoleTemplates
        {
            get
            {
                return new GraphServiceDirectoryRoleTemplatesCollectionRequestBuilder(this.BaseUrl + "/directoryRoleTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectorySettingTemplates request builder.
        /// </summary>
        public IGraphServiceDirectorySettingTemplatesCollectionRequestBuilder DirectorySettingTemplates
        {
            get
            {
                return new GraphServiceDirectorySettingTemplatesCollectionRequestBuilder(this.BaseUrl + "/directorySettingTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceOrganization request builder.
        /// </summary>
        public IGraphServiceOrganizationCollectionRequestBuilder Organization
        {
            get
            {
                return new GraphServiceOrganizationCollectionRequestBuilder(this.BaseUrl + "/organization", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceOauth2PermissionGrants request builder.
        /// </summary>
        public IGraphServiceOauth2PermissionGrantsCollectionRequestBuilder Oauth2PermissionGrants
        {
            get
            {
                return new GraphServiceOauth2PermissionGrantsCollectionRequestBuilder(this.BaseUrl + "/oauth2PermissionGrants", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceScopedRoleMemberships request builder.
        /// </summary>
        public IGraphServiceScopedRoleMembershipsCollectionRequestBuilder ScopedRoleMemberships
        {
            get
            {
                return new GraphServiceScopedRoleMembershipsCollectionRequestBuilder(this.BaseUrl + "/scopedRoleMemberships", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceServicePrincipals request builder.
        /// </summary>
        public IGraphServiceServicePrincipalsCollectionRequestBuilder ServicePrincipals
        {
            get
            {
                return new GraphServiceServicePrincipalsCollectionRequestBuilder(this.BaseUrl + "/servicePrincipals", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSettings request builder.
        /// </summary>
        public IGraphServiceSettingsCollectionRequestBuilder Settings
        {
            get
            {
                return new GraphServiceSettingsCollectionRequestBuilder(this.BaseUrl + "/settings", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSubscribedSkus request builder.
        /// </summary>
        public IGraphServiceSubscribedSkusCollectionRequestBuilder SubscribedSkus
        {
            get
            {
                return new GraphServiceSubscribedSkusCollectionRequestBuilder(this.BaseUrl + "/subscribedSkus", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceUsers request builder.
        /// </summary>
        public IGraphServiceUsersCollectionRequestBuilder Users
        {
            get
            {
                return new GraphServiceUsersCollectionRequestBuilder(this.BaseUrl + "/users", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePolicies request builder.
        /// </summary>
        public IGraphServicePoliciesCollectionRequestBuilder Policies
        {
            get
            {
                return new GraphServicePoliciesCollectionRequestBuilder(this.BaseUrl + "/policies", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceContracts request builder.
        /// </summary>
        public IGraphServiceContractsCollectionRequestBuilder Contracts
        {
            get
            {
                return new GraphServiceContractsCollectionRequestBuilder(this.BaseUrl + "/contracts", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceWorkbooks request builder.
        /// </summary>
        public IGraphServiceWorkbooksCollectionRequestBuilder Workbooks
        {
            get
            {
                return new GraphServiceWorkbooksCollectionRequestBuilder(this.BaseUrl + "/workbooks", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDrives request builder.
        /// </summary>
        public IGraphServiceDrivesCollectionRequestBuilder Drives
        {
            get
            {
                return new GraphServiceDrivesCollectionRequestBuilder(this.BaseUrl + "/drives", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceShares request builder.
        /// </summary>
        public IGraphServiceSharesCollectionRequestBuilder Shares
        {
            get
            {
                return new GraphServiceSharesCollectionRequestBuilder(this.BaseUrl + "/shares", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSites request builder.
        /// </summary>
        public IGraphServiceSitesCollectionRequestBuilder Sites
        {
            get
            {
                return new GraphServiceSitesCollectionRequestBuilder(this.BaseUrl + "/sites", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSubscriptions request builder.
        /// </summary>
        public IGraphServiceSubscriptionsCollectionRequestBuilder Subscriptions
        {
            get
            {
                return new GraphServiceSubscriptionsCollectionRequestBuilder(this.BaseUrl + "/subscriptions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceIdentityRiskEvents request builder.
        /// </summary>
        public IGraphServiceIdentityRiskEventsCollectionRequestBuilder IdentityRiskEvents
        {
            get
            {
                return new GraphServiceIdentityRiskEventsCollectionRequestBuilder(this.BaseUrl + "/identityRiskEvents", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceImpossibleTravelRiskEvents request builder.
        /// </summary>
        public IGraphServiceImpossibleTravelRiskEventsCollectionRequestBuilder ImpossibleTravelRiskEvents
        {
            get
            {
                return new GraphServiceImpossibleTravelRiskEventsCollectionRequestBuilder(this.BaseUrl + "/impossibleTravelRiskEvents", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceLeakedCredentialsRiskEvents request builder.
        /// </summary>
        public IGraphServiceLeakedCredentialsRiskEventsCollectionRequestBuilder LeakedCredentialsRiskEvents
        {
            get
            {
                return new GraphServiceLeakedCredentialsRiskEventsCollectionRequestBuilder(this.BaseUrl + "/leakedCredentialsRiskEvents", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAnonymousIpRiskEvents request builder.
        /// </summary>
        public IGraphServiceAnonymousIpRiskEventsCollectionRequestBuilder AnonymousIpRiskEvents
        {
            get
            {
                return new GraphServiceAnonymousIpRiskEventsCollectionRequestBuilder(this.BaseUrl + "/anonymousIpRiskEvents", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSuspiciousIpRiskEvents request builder.
        /// </summary>
        public IGraphServiceSuspiciousIpRiskEventsCollectionRequestBuilder SuspiciousIpRiskEvents
        {
            get
            {
                return new GraphServiceSuspiciousIpRiskEventsCollectionRequestBuilder(this.BaseUrl + "/suspiciousIpRiskEvents", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceUnfamiliarLocationRiskEvents request builder.
        /// </summary>
        public IGraphServiceUnfamiliarLocationRiskEventsCollectionRequestBuilder UnfamiliarLocationRiskEvents
        {
            get
            {
                return new GraphServiceUnfamiliarLocationRiskEventsCollectionRequestBuilder(this.BaseUrl + "/unfamiliarLocationRiskEvents", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceMalwareRiskEvents request builder.
        /// </summary>
        public IGraphServiceMalwareRiskEventsCollectionRequestBuilder MalwareRiskEvents
        {
            get
            {
                return new GraphServiceMalwareRiskEventsCollectionRequestBuilder(this.BaseUrl + "/malwareRiskEvents", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceRiskDetections request builder.
        /// </summary>
        public IGraphServiceRiskDetectionsCollectionRequestBuilder RiskDetections
        {
            get
            {
                return new GraphServiceRiskDetectionsCollectionRequestBuilder(this.BaseUrl + "/riskDetections", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceRiskyUsers request builder.
        /// </summary>
        public IGraphServiceRiskyUsersCollectionRequestBuilder RiskyUsers
        {
            get
            {
                return new GraphServiceRiskyUsersCollectionRequestBuilder(this.BaseUrl + "/riskyUsers", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedRoles request builder.
        /// </summary>
        public IGraphServicePrivilegedRolesCollectionRequestBuilder PrivilegedRoles
        {
            get
            {
                return new GraphServicePrivilegedRolesCollectionRequestBuilder(this.BaseUrl + "/privilegedRoles", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedRoleAssignments request builder.
        /// </summary>
        public IGraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder PrivilegedRoleAssignments
        {
            get
            {
                return new GraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder(this.BaseUrl + "/privilegedRoleAssignments", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedOperationEvents request builder.
        /// </summary>
        public IGraphServicePrivilegedOperationEventsCollectionRequestBuilder PrivilegedOperationEvents
        {
            get
            {
                return new GraphServicePrivilegedOperationEventsCollectionRequestBuilder(this.BaseUrl + "/privilegedOperationEvents", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedSignupStatus request builder.
        /// </summary>
        public IGraphServicePrivilegedSignupStatusCollectionRequestBuilder PrivilegedSignupStatus
        {
            get
            {
                return new GraphServicePrivilegedSignupStatusCollectionRequestBuilder(this.BaseUrl + "/privilegedSignupStatus", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedApproval request builder.
        /// </summary>
        public IGraphServicePrivilegedApprovalCollectionRequestBuilder PrivilegedApproval
        {
            get
            {
                return new GraphServicePrivilegedApprovalCollectionRequestBuilder(this.BaseUrl + "/privilegedApproval", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedRoleAssignmentRequests request builder.
        /// </summary>
        public IGraphServicePrivilegedRoleAssignmentRequestsCollectionRequestBuilder PrivilegedRoleAssignmentRequests
        {
            get
            {
                return new GraphServicePrivilegedRoleAssignmentRequestsCollectionRequestBuilder(this.BaseUrl + "/privilegedRoleAssignmentRequests", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceInvitations request builder.
        /// </summary>
        public IGraphServiceInvitationsCollectionRequestBuilder Invitations
        {
            get
            {
                return new GraphServiceInvitationsCollectionRequestBuilder(this.BaseUrl + "/invitations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceCommands request builder.
        /// </summary>
        public IGraphServiceCommandsCollectionRequestBuilder Commands
        {
            get
            {
                return new GraphServiceCommandsCollectionRequestBuilder(this.BaseUrl + "/commands", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePayloadResponse request builder.
        /// </summary>
        public IGraphServicePayloadResponseCollectionRequestBuilder PayloadResponse
        {
            get
            {
                return new GraphServicePayloadResponseCollectionRequestBuilder(this.BaseUrl + "/payloadResponse", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceTeams request builder.
        /// </summary>
        public IGraphServiceTeamsCollectionRequestBuilder Teams
        {
            get
            {
                return new GraphServiceTeamsCollectionRequestBuilder(this.BaseUrl + "/teams", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceTeamsTemplates request builder.
        /// </summary>
        public IGraphServiceTeamsTemplatesCollectionRequestBuilder TeamsTemplates
        {
            get
            {
                return new GraphServiceTeamsTemplatesCollectionRequestBuilder(this.BaseUrl + "/teamsTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroupLifecyclePolicies request builder.
        /// </summary>
        public IGraphServiceGroupLifecyclePoliciesCollectionRequestBuilder GroupLifecyclePolicies
        {
            get
            {
                return new GraphServiceGroupLifecyclePoliciesCollectionRequestBuilder(this.BaseUrl + "/groupLifecyclePolicies", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceIdentityProviders request builder.
        /// </summary>
        public IGraphServiceIdentityProvidersCollectionRequestBuilder IdentityProviders
        {
            get
            {
                return new GraphServiceIdentityProvidersCollectionRequestBuilder(this.BaseUrl + "/identityProviders", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceTrustFrameworkPolicies request builder.
        /// </summary>
        public IGraphServiceTrustFrameworkPoliciesCollectionRequestBuilder TrustFrameworkPolicies
        {
            get
            {
                return new GraphServiceTrustFrameworkPoliciesCollectionRequestBuilder(this.BaseUrl + "/trustFrameworkPolicies", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceFunctions request builder.
        /// </summary>
        public IGraphServiceFunctionsCollectionRequestBuilder Functions
        {
            get
            {
                return new GraphServiceFunctionsCollectionRequestBuilder(this.BaseUrl + "/functions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceFilterOperators request builder.
        /// </summary>
        public IGraphServiceFilterOperatorsCollectionRequestBuilder FilterOperators
        {
            get
            {
                return new GraphServiceFilterOperatorsCollectionRequestBuilder(this.BaseUrl + "/filterOperators", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDataPolicyOperations request builder.
        /// </summary>
        public IGraphServiceDataPolicyOperationsCollectionRequestBuilder DataPolicyOperations
        {
            get
            {
                return new GraphServiceDataPolicyOperationsCollectionRequestBuilder(this.BaseUrl + "/dataPolicyOperations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceChats request builder.
        /// </summary>
        public IGraphServiceChatsCollectionRequestBuilder Chats
        {
            get
            {
                return new GraphServiceChatsCollectionRequestBuilder(this.BaseUrl + "/chats", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAgreements request builder.
        /// </summary>
        public IGraphServiceAgreementsCollectionRequestBuilder Agreements
        {
            get
            {
                return new GraphServiceAgreementsCollectionRequestBuilder(this.BaseUrl + "/agreements", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAgreementAcceptances request builder.
        /// </summary>
        public IGraphServiceAgreementAcceptancesCollectionRequestBuilder AgreementAcceptances
        {
            get
            {
                return new GraphServiceAgreementAcceptancesCollectionRequestBuilder(this.BaseUrl + "/agreementAcceptances", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceBookingBusinesses request builder.
        /// </summary>
        public IGraphServiceBookingBusinessesCollectionRequestBuilder BookingBusinesses
        {
            get
            {
                return new GraphServiceBookingBusinessesCollectionRequestBuilder(this.BaseUrl + "/bookingBusinesses", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceBookingCurrencies request builder.
        /// </summary>
        public IGraphServiceBookingCurrenciesCollectionRequestBuilder BookingCurrencies
        {
            get
            {
                return new GraphServiceBookingCurrenciesCollectionRequestBuilder(this.BaseUrl + "/bookingCurrencies", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedAccess request builder.
        /// </summary>
        public IGraphServicePrivilegedAccessCollectionRequestBuilder PrivilegedAccess
        {
            get
            {
                return new GraphServicePrivilegedAccessCollectionRequestBuilder(this.BaseUrl + "/privilegedAccess", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceResources request builder.
        /// </summary>
        public IGraphServiceGovernanceResourcesCollectionRequestBuilder GovernanceResources
        {
            get
            {
                return new GraphServiceGovernanceResourcesCollectionRequestBuilder(this.BaseUrl + "/governanceResources", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceSubjects request builder.
        /// </summary>
        public IGraphServiceGovernanceSubjectsCollectionRequestBuilder GovernanceSubjects
        {
            get
            {
                return new GraphServiceGovernanceSubjectsCollectionRequestBuilder(this.BaseUrl + "/governanceSubjects", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceRoleDefinitions request builder.
        /// </summary>
        public IGraphServiceGovernanceRoleDefinitionsCollectionRequestBuilder GovernanceRoleDefinitions
        {
            get
            {
                return new GraphServiceGovernanceRoleDefinitionsCollectionRequestBuilder(this.BaseUrl + "/governanceRoleDefinitions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceRoleAssignments request builder.
        /// </summary>
        public IGraphServiceGovernanceRoleAssignmentsCollectionRequestBuilder GovernanceRoleAssignments
        {
            get
            {
                return new GraphServiceGovernanceRoleAssignmentsCollectionRequestBuilder(this.BaseUrl + "/governanceRoleAssignments", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceRoleAssignmentRequests request builder.
        /// </summary>
        public IGraphServiceGovernanceRoleAssignmentRequestsCollectionRequestBuilder GovernanceRoleAssignmentRequests
        {
            get
            {
                return new GraphServiceGovernanceRoleAssignmentRequestsCollectionRequestBuilder(this.BaseUrl + "/governanceRoleAssignmentRequests", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceRoleSettings request builder.
        /// </summary>
        public IGraphServiceGovernanceRoleSettingsCollectionRequestBuilder GovernanceRoleSettings
        {
            get
            {
                return new GraphServiceGovernanceRoleSettingsCollectionRequestBuilder(this.BaseUrl + "/governanceRoleSettings", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAccessReviews request builder.
        /// </summary>
        public IGraphServiceAccessReviewsCollectionRequestBuilder AccessReviews
        {
            get
            {
                return new GraphServiceAccessReviewsCollectionRequestBuilder(this.BaseUrl + "/accessReviews", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceBusinessFlowTemplates request builder.
        /// </summary>
        public IGraphServiceBusinessFlowTemplatesCollectionRequestBuilder BusinessFlowTemplates
        {
            get
            {
                return new GraphServiceBusinessFlowTemplatesCollectionRequestBuilder(this.BaseUrl + "/businessFlowTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAccessReviewDecisions request builder.
        /// </summary>
        public IGraphServiceAccessReviewDecisionsCollectionRequestBuilder AccessReviewDecisions
        {
            get
            {
                return new GraphServiceAccessReviewDecisionsCollectionRequestBuilder(this.BaseUrl + "/accessReviewDecisions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrograms request builder.
        /// </summary>
        public IGraphServiceProgramsCollectionRequestBuilder Programs
        {
            get
            {
                return new GraphServiceProgramsCollectionRequestBuilder(this.BaseUrl + "/programs", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceProgramControls request builder.
        /// </summary>
        public IGraphServiceProgramControlsCollectionRequestBuilder ProgramControls
        {
            get
            {
                return new GraphServiceProgramControlsCollectionRequestBuilder(this.BaseUrl + "/programControls", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceProgramControlTypes request builder.
        /// </summary>
        public IGraphServiceProgramControlTypesCollectionRequestBuilder ProgramControlTypes
        {
            get
            {
                return new GraphServiceProgramControlTypesCollectionRequestBuilder(this.BaseUrl + "/programControlTypes", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceOnPremisesPublishingProfiles request builder.
        /// </summary>
        public IGraphServiceOnPremisesPublishingProfilesCollectionRequestBuilder OnPremisesPublishingProfiles
        {
            get
            {
                return new GraphServiceOnPremisesPublishingProfilesCollectionRequestBuilder(this.BaseUrl + "/onPremisesPublishingProfiles", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceApplicationTemplates request builder.
        /// </summary>
        public IGraphServiceApplicationTemplatesCollectionRequestBuilder ApplicationTemplates
        {
            get
            {
                return new GraphServiceApplicationTemplatesCollectionRequestBuilder(this.BaseUrl + "/applicationTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceApp request builder.
        /// </summary>
        public ICommsApplicationRequestBuilder App
        {
            get
            {
                return new CommsApplicationRequestBuilder(this.BaseUrl + "/app", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceMe request builder.
        /// </summary>
        public IUserRequestBuilder Me
        {
            get
            {
                return new UserRequestBuilder(this.BaseUrl + "/me", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectory request builder.
        /// </summary>
        public IDirectoryRequestBuilder Directory
        {
            get
            {
                return new DirectoryRequestBuilder(this.BaseUrl + "/directory", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDrive request builder.
        /// </summary>
        public IDriveRequestBuilder Drive
        {
            get
            {
                return new DriveRequestBuilder(this.BaseUrl + "/drive", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePlanner request builder.
        /// </summary>
        public IPlannerRequestBuilder Planner
        {
            get
            {
                return new PlannerRequestBuilder(this.BaseUrl + "/planner", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAuditLogs request builder.
        /// </summary>
        public IAuditLogRootRequestBuilder AuditLogs
        {
            get
            {
                return new AuditLogRootRequestBuilder(this.BaseUrl + "/auditLogs", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceReports request builder.
        /// </summary>
        public IReportRootRequestBuilder Reports
        {
            get
            {
                return new ReportRootRequestBuilder(this.BaseUrl + "/reports", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDeviceManagement request builder.
        /// </summary>
        public IDeviceManagementRequestBuilder DeviceManagement
        {
            get
            {
                return new DeviceManagementRequestBuilder(this.BaseUrl + "/deviceManagement", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDeviceAppManagement request builder.
        /// </summary>
        public IDeviceAppManagementRequestBuilder DeviceAppManagement
        {
            get
            {
                return new DeviceAppManagementRequestBuilder(this.BaseUrl + "/deviceAppManagement", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAppCatalogs request builder.
        /// </summary>
        public IAppCatalogsRequestBuilder AppCatalogs
        {
            get
            {
                return new AppCatalogsRequestBuilder(this.BaseUrl + "/appCatalogs", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceTrustFramework request builder.
        /// </summary>
        public ITrustFrameworkRequestBuilder TrustFramework
        {
            get
            {
                return new TrustFrameworkRequestBuilder(this.BaseUrl + "/trustFramework", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceEducation request builder.
        /// </summary>
        public IEducationRootRequestBuilder Education
        {
            get
            {
                return new EducationRootRequestBuilder(this.BaseUrl + "/education", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDataClassification request builder.
        /// </summary>
        public IDataClassificationServiceRequestBuilder DataClassification
        {
            get
            {
                return new DataClassificationServiceRequestBuilder(this.BaseUrl + "/dataClassification", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSecurity request builder.
        /// </summary>
        public ISecurityRequestBuilder Security
        {
            get
            {
                return new SecurityRequestBuilder(this.BaseUrl + "/Security", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceOfficeConfiguration request builder.
        /// </summary>
        public IOfficeConfigurationRequestBuilder OfficeConfiguration
        {
            get
            {
                return new OfficeConfigurationRequestBuilder(this.BaseUrl + "/officeConfiguration", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceFinancials request builder.
        /// </summary>
        public IFinancialsRequestBuilder Financials
        {
            get
            {
                return new FinancialsRequestBuilder(this.BaseUrl + "/financials", this);
            }
        }
    
    }
}
