using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminUnit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentRoleId { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? AccountId { get; set; }

    public bool IsDirectoryEntry { get; set; }

    public string TimeZoneId { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int SysAdminUnitTypeValue { get; set; }

    public bool Active { get; set; }

    public bool LoggedIn { get; set; }

    public Guid? SysCultureId { get; set; }

    public int LoginAttemptCount { get; set; }

    public string SourceControlLogin { get; set; } = null!;

    public string SourceControlPassword { get; set; } = null!;

    public int ConnectionType { get; set; }

    public DateTime? UnblockTime { get; set; }

    public DateTime? PasswordExpireDate { get; set; }

    public bool ForceChangePassword { get; set; }

    public Guid? DateTimeFormatId { get; set; }

    public bool SynchronizeWithLdap { get; set; }

    public string Ldapentry { get; set; } = null!;

    public string LdapentryId { get; set; } = null!;

    public string LdapentryDn { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? HomePageId { get; set; }

    public int SessionTimeout { get; set; }

    public Guid? LdapelementId { get; set; }

    public Guid? PortalAccountId { get; set; }

    public string Email { get; set; } = null!;

    public string OpenIdsub { get; set; } = null!;

    public virtual Account? Account { get; set; }

    public virtual ICollection<AdminUnitFeatureState> AdminUnitFeatureStates { get; set; } = new List<AdminUnitFeatureState>();

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual ICollection<ChatQueueOperator> ChatQueueOperators { get; set; } = new List<ChatQueueOperator>();

    public virtual Contact? Contact { get; set; }

    public virtual SysLanguage? DateTimeFormat { get; set; }

    public virtual ICollection<EmailDefRight> EmailDefRights { get; set; } = new List<EmailDefRight>();

    public virtual ICollection<FolderFavorite> FolderFavorites { get; set; } = new List<FolderFavorite>();

    public virtual SysModule? HomePage { get; set; }

    public virtual ICollection<SysAdminUnit> InverseParentRole { get; set; } = new List<SysAdminUnit>();

    public virtual Ldapelement? Ldapelement { get; set; }

    public virtual ICollection<MailboxSyncSetting> MailboxSyncSettings { get; set; } = new List<MailboxSyncSetting>();

    public virtual ICollection<MultiDeleteQueue> MultiDeleteQueues { get; set; } = new List<MultiDeleteQueue>();

    public virtual ICollection<OauthApplication> OauthApplications { get; set; } = new List<OauthApplication>();

    public virtual ICollection<OauthClientApp> OauthClientApps { get; set; } = new List<OauthClientApp>();

    public virtual ICollection<OauthTokenStorage> OauthTokenStorages { get; set; } = new List<OauthTokenStorage>();

    public virtual ICollection<OmniChat> OmniChatDirectedOperators { get; set; } = new List<OmniChat>();

    public virtual ICollection<OmniChat> OmniChatOperators { get; set; } = new List<OmniChat>();

    public virtual ICollection<OperatorSession> OperatorSessions { get; set; } = new List<OperatorSession>();

    public virtual ICollection<OptionalFuncSspRole> OptionalFuncSspRoleFuncRoles { get; set; } = new List<OptionalFuncSspRole>();

    public virtual ICollection<OptionalFuncSspRole> OptionalFuncSspRoleOrgRoles { get; set; } = new List<OptionalFuncSspRole>();

    public virtual ICollection<OrganizationProperty> OrganizationProperties { get; set; } = new List<OrganizationProperty>();

    public virtual SysAdminUnit? ParentRole { get; set; }

    public virtual Account? PortalAccount { get; set; }

    public virtual ICollection<PushNotificationToken> PushNotificationTokens { get; set; } = new List<PushNotificationToken>();

    public virtual ICollection<QuickAddMenuSetting> QuickAddMenuSettings { get; set; } = new List<QuickAddMenuSetting>();

    public virtual ICollection<SocialAccount> SocialAccounts { get; set; } = new List<SocialAccount>();

    public virtual ICollection<SocialChannelPublisher> SocialChannelPublishers { get; set; } = new List<SocialChannelPublisher>();

    public virtual ICollection<SocialFeedFavoriteTpl> SocialFeedFavoriteTpls { get; set; } = new List<SocialFeedFavoriteTpl>();

    public virtual ICollection<SocialLike> SocialLikes { get; set; } = new List<SocialLike>();

    public virtual ICollection<SocialSubscription> SocialSubscriptions { get; set; } = new List<SocialSubscription>();

    public virtual ICollection<SocialUnsubscription> SocialUnsubscriptions { get; set; } = new List<SocialUnsubscription>();

    public virtual ICollection<SysAccountAlternativeNameRight> SysAccountAlternativeNameRights { get; set; } = new List<SysAccountAlternativeNameRight>();

    public virtual ICollection<SysAccountFolderRight> SysAccountFolderRights { get; set; } = new List<SysAccountFolderRight>();

    public virtual ICollection<SysAccountRight> SysAccountRights { get; set; } = new List<SysAccountRight>();

    public virtual ICollection<SysAccountTagRight> SysAccountTagRights { get; set; } = new List<SysAccountTagRight>();

    public virtual ICollection<SysActivityFolderRight> SysActivityFolderRights { get; set; } = new List<SysActivityFolderRight>();

    public virtual ICollection<SysActivityRight> SysActivityRights { get; set; } = new List<SysActivityRight>();

    public virtual ICollection<SysActivityTagRight> SysActivityTagRights { get; set; } = new List<SysActivityTagRight>();

    public virtual ICollection<SysAdminOperationGrantee> SysAdminOperationGrantees { get; set; } = new List<SysAdminOperationGrantee>();

    public virtual ICollection<SysAdminUnitInFolder> SysAdminUnitInFolders { get; set; } = new List<SysAdminUnitInFolder>();

    public virtual ICollection<SysAdminUnitInRole> SysAdminUnitInRoles { get; set; } = new List<SysAdminUnitInRole>();

    public virtual ICollection<SysAdminUnitInWorkplace> SysAdminUnitInWorkplaces { get; set; } = new List<SysAdminUnitInWorkplace>();

    public virtual ICollection<SysAdminUnitIprange> SysAdminUnitIpranges { get; set; } = new List<SysAdminUnitIprange>();

    public virtual ICollection<SysAlmRole> SysAlmRoles { get; set; } = new List<SysAlmRole>();

    public virtual ICollection<SysCallTagRight> SysCallTagRights { get; set; } = new List<SysCallTagRight>();

    public virtual ICollection<SysContactFolderRight> SysContactFolderRights { get; set; } = new List<SysContactFolderRight>();

    public virtual ICollection<SysContactRight> SysContactRights { get; set; } = new List<SysContactRight>();

    public virtual ICollection<SysContactTagRight> SysContactTagRights { get; set; } = new List<SysContactTagRight>();

    public virtual ICollection<SysContentBlockInTagRight> SysContentBlockInTagRights { get; set; } = new List<SysContentBlockInTagRight>();

    public virtual ICollection<SysContentBlockTagRight> SysContentBlockTagRights { get; set; } = new List<SysContentBlockTagRight>();

    public virtual SysCulture? SysCulture { get; set; }

    public virtual ICollection<SysDashboardRight> SysDashboardRights { get; set; } = new List<SysDashboardRight>();

    public virtual ICollection<SysDisplayDateFormatRight> SysDisplayDateFormatRights { get; set; } = new List<SysDisplayDateFormatRight>();

    public virtual ICollection<SysDuplicatesRuleTagRight> SysDuplicatesRuleTagRights { get; set; } = new List<SysDuplicatesRuleTagRight>();

    public virtual ICollection<SysEmailTemplateFolderRight> SysEmailTemplateFolderRights { get; set; } = new List<SysEmailTemplateFolderRight>();

    public virtual ICollection<SysEmailTemplateInFolderRight> SysEmailTemplateInFolderRights { get; set; } = new List<SysEmailTemplateInFolderRight>();

    public virtual ICollection<SysEmailTemplateInTagRight> SysEmailTemplateInTagRights { get; set; } = new List<SysEmailTemplateInTagRight>();

    public virtual ICollection<SysEmailTemplateTagRight> SysEmailTemplateTagRights { get; set; } = new List<SysEmailTemplateTagRight>();

    public virtual ICollection<SysEmployeeFolderRight> SysEmployeeFolderRights { get; set; } = new List<SysEmployeeFolderRight>();

    public virtual ICollection<SysEmployeeTagRight> SysEmployeeTagRights { get; set; } = new List<SysEmployeeTagRight>();

    public virtual ICollection<SysEntityOperationGrantee> SysEntityOperationGrantees { get; set; } = new List<SysEntityOperationGrantee>();

    public virtual ICollection<SysExternalAccessFolderRight> SysExternalAccessFolderRights { get; set; } = new List<SysExternalAccessFolderRight>();

    public virtual ICollection<SysExternalAccessInFolderRight> SysExternalAccessInFolderRights { get; set; } = new List<SysExternalAccessInFolderRight>();

    public virtual ICollection<SysExternalAccessInTagRight> SysExternalAccessInTagRights { get; set; } = new List<SysExternalAccessInTagRight>();

    public virtual ICollection<SysExternalAccessTagRight> SysExternalAccessTagRights { get; set; } = new List<SysExternalAccessTagRight>();

    public virtual ICollection<SysFuncRoleInOrgRole> SysFuncRoleInOrgRoleFuncRoles { get; set; } = new List<SysFuncRoleInOrgRole>();

    public virtual ICollection<SysFuncRoleInOrgRole> SysFuncRoleInOrgRoleOrgRoles { get; set; } = new List<SysFuncRoleInOrgRole>();

    public virtual ICollection<SysGeneratedWebFormTagRight> SysGeneratedWebFormTagRights { get; set; } = new List<SysGeneratedWebFormTagRight>();

    public virtual ICollection<SysImportSessionRight> SysImportSessionRights { get; set; } = new List<SysImportSessionRight>();

    public virtual ICollection<SysKnowledgeBaseFolderRight> SysKnowledgeBaseFolderRights { get; set; } = new List<SysKnowledgeBaseFolderRight>();

    public virtual ICollection<SysKnowledgeBaseRight> SysKnowledgeBaseRights { get; set; } = new List<SysKnowledgeBaseRight>();

    public virtual ICollection<SysKnowledgeBaseTagV2right> SysKnowledgeBaseTagV2rights { get; set; } = new List<SysKnowledgeBaseTagV2right>();

    public virtual ICollection<SysLastUserPassword> SysLastUserPasswords { get; set; } = new List<SysLastUserPassword>();

    public virtual ICollection<SysLicUser> SysLicUsers { get; set; } = new List<SysLicUser>();

    public virtual ICollection<SysLookupFolderRight> SysLookupFolderRights { get; set; } = new List<SysLookupFolderRight>();

    public virtual ICollection<SysLookupTagRight> SysLookupTagRights { get; set; } = new List<SysLookupTagRight>();

    public virtual ICollection<SysMailboxSyncSettingsRight> SysMailboxSyncSettingsRights { get; set; } = new List<SysMailboxSyncSettingsRight>();

    public virtual ICollection<SysMkpInstAppNewsFolderRight> SysMkpInstAppNewsFolderRights { get; set; } = new List<SysMkpInstAppNewsFolderRight>();

    public virtual ICollection<SysMkpInstAppNewsInFolderRight> SysMkpInstAppNewsInFolderRights { get; set; } = new List<SysMkpInstAppNewsInFolderRight>();

    public virtual ICollection<SysMkpInstAppNewsInTagRight> SysMkpInstAppNewsInTagRights { get; set; } = new List<SysMkpInstAppNewsInTagRight>();

    public virtual ICollection<SysMkpInstalledAppNewsTagRight> SysMkpInstalledAppNewsTagRights { get; set; } = new List<SysMkpInstalledAppNewsTagRight>();

    public virtual ICollection<SysMlmodelTagRight> SysMlmodelTagRights { get; set; } = new List<SysMlmodelTagRight>();

    public virtual ICollection<SysMsgUserSetting> SysMsgUserSettings { get; set; } = new List<SysMsgUserSetting>();

    public virtual ICollection<SysOauth20AppFolderRight> SysOauth20AppFolderRights { get; set; } = new List<SysOauth20AppFolderRight>();

    public virtual ICollection<SysOauth20AppInFolderRight> SysOauth20AppInFolderRights { get; set; } = new List<SysOauth20AppInFolderRight>();

    public virtual ICollection<SysOauth20AppInTagRight> SysOauth20AppInTagRights { get; set; } = new List<SysOauth20AppInTagRight>();

    public virtual ICollection<SysOauth20AppTagRight> SysOauth20AppTagRights { get; set; } = new List<SysOauth20AppTagRight>();

    public virtual ICollection<SysOmniChatFolderRight> SysOmniChatFolderRights { get; set; } = new List<SysOmniChatFolderRight>();

    public virtual ICollection<SysOmniChatInFolderRight> SysOmniChatInFolderRights { get; set; } = new List<SysOmniChatInFolderRight>();

    public virtual ICollection<SysOmniChatInTagRight> SysOmniChatInTagRights { get; set; } = new List<SysOmniChatInTagRight>();

    public virtual ICollection<SysOmniChatTagRight> SysOmniChatTagRights { get; set; } = new List<SysOmniChatTagRight>();

    public virtual ICollection<SysProcessLogFolderRight> SysProcessLogFolderRights { get; set; } = new List<SysProcessLogFolderRight>();

    public virtual ICollection<SysProcessSchemaOperationRight> SysProcessSchemaOperationRights { get; set; } = new List<SysProcessSchemaOperationRight>();

    public virtual ICollection<SysProductRight> SysProductRights { get; set; } = new List<SysProductRight>();

    public virtual ICollection<SysProductTagRight> SysProductTagRights { get; set; } = new List<SysProductTagRight>();

    public virtual ICollection<SysProfileDatum> SysProfileData { get; set; } = new List<SysProfileDatum>();

    public virtual ICollection<SysRecentEntity> SysRecentEntities { get; set; } = new List<SysRecentEntity>();

    public virtual ICollection<SysRegistrationDatum> SysRegistrationData { get; set; } = new List<SysRegistrationDatum>();

    public virtual ICollection<SysReportRight> SysReportRights { get; set; } = new List<SysReportRight>();

    public virtual ICollection<SysRepositoryUser> SysRepositoryUsers { get; set; } = new List<SysRepositoryUser>();

    public virtual ICollection<SysRoleInMobWorkplace> SysRoleInMobWorkplaces { get; set; } = new List<SysRoleInMobWorkplace>();

    public virtual ICollection<SysSchema> SysSchemas { get; set; } = new List<SysSchema>();

    public virtual ICollection<SysSettingsValue> SysSettingsValues { get; set; } = new List<SysSettingsValue>();

    public virtual ICollection<SysSocialChannelFolderRight> SysSocialChannelFolderRights { get; set; } = new List<SysSocialChannelFolderRight>();

    public virtual ICollection<SysSocialChannelRight> SysSocialChannelRights { get; set; } = new List<SysSocialChannelRight>();

    public virtual ICollection<SysSocialChannelTagRight> SysSocialChannelTagRights { get; set; } = new List<SysSocialChannelTagRight>();

    public virtual ICollection<SysSocialSubscriptionRight> SysSocialSubscriptionRights { get; set; } = new List<SysSocialSubscriptionRight>();

    public virtual ICollection<SysTranslationFolderRight> SysTranslationFolderRights { get; set; } = new List<SysTranslationFolderRight>();

    public virtual ICollection<SysTranslationTagRight> SysTranslationTagRights { get; set; } = new List<SysTranslationTagRight>();

    public virtual ICollection<SysUserInRole> SysUserInRoleSysRoles { get; set; } = new List<SysUserInRole>();

    public virtual ICollection<SysUserInRole> SysUserInRoleSysUsers { get; set; } = new List<SysUserInRole>();

    public virtual ICollection<SysUserSession> SysUserSessions { get; set; } = new List<SysUserSession>();

    public virtual ICollection<SysVwSysProcessFolderRight> SysVwSysProcessFolderRights { get; set; } = new List<SysVwSysProcessFolderRight>();

    public virtual ICollection<SysWebServiceV2folderRight> SysWebServiceV2folderRights { get; set; } = new List<SysWebServiceV2folderRight>();

    public virtual ICollection<SysWebServiceV2inFolderRight> SysWebServiceV2inFolderRights { get; set; } = new List<SysWebServiceV2inFolderRight>();

    public virtual ICollection<SysWebServiceV2inTagRight> SysWebServiceV2inTagRights { get; set; } = new List<SysWebServiceV2inTagRight>();

    public virtual ICollection<SysWebServiceV2tagRight> SysWebServiceV2tagRights { get; set; } = new List<SysWebServiceV2tagRight>();

    public virtual ICollection<SysWsysAccountTagRight> SysWsysAccountTagRights { get; set; } = new List<SysWsysAccountTagRight>();

    public virtual ICollection<TotpSecret> TotpSecrets { get; set; } = new List<TotpSecret>();

    public virtual ICollection<TotpSetupToken> TotpSetupTokens { get; set; } = new List<TotpSetupToken>();
}
