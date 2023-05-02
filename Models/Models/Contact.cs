using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Contact
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? AccountId { get; set; }

    public Guid? OwnerId { get; set; }

    public int ProcessListeners { get; set; }

    public string Dear { get; set; } = null!;

    public Guid? SalutationTypeId { get; set; }

    public Guid? GenderId { get; set; }

    public Guid? DecisionRoleId { get; set; }

    public Guid? TypeId { get; set; }

    public Guid? JobId { get; set; }

    public string JobTitle { get; set; } = null!;

    public Guid? DepartmentId { get; set; }

    public DateTime? BirthDate { get; set; }

    public string Phone { get; set; } = null!;

    public string MobilePhone { get; set; } = null!;

    public string HomePhone { get; set; } = null!;

    public string Skype { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Guid? AddressTypeId { get; set; }

    public string Address { get; set; } = null!;

    public Guid? CityId { get; set; }

    public Guid? RegionId { get; set; }

    public string Zip { get; set; } = null!;

    public Guid? CountryId { get; set; }

    public bool DoNotUseEmail { get; set; }

    public bool DoNotUseCall { get; set; }

    public bool DoNotUseFax { get; set; }

    public bool DoNotUseSms { get; set; }

    public bool DoNotUseMail { get; set; }

    public string Notes { get; set; } = null!;

    public string Facebook { get; set; } = null!;

    public string LinkedIn { get; set; } = null!;

    public string Twitter { get; set; } = null!;

    public string FacebookId { get; set; } = null!;

    public string LinkedInId { get; set; } = null!;

    public string TwitterId { get; set; } = null!;

    public byte[]? ContactPhoto { get; set; }

    public Guid? TwitterAfdaid { get; set; }

    public Guid? FacebookAfdaid { get; set; }

    public Guid? LinkedInAfdaid { get; set; }

    public Guid? PhotoId { get; set; }

    public string Gpsn { get; set; } = null!;

    public string Gpse { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string GivenName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public bool Confirmed { get; set; }

    public Guid? LanguageId { get; set; }

    public int Completeness { get; set; }

    public int Age { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<AccountBillingInfo> AccountBillingInfoAccountManagers { get; set; } = new List<AccountBillingInfo>();

    public virtual ICollection<AccountBillingInfo> AccountBillingInfoChiefAccountants { get; set; } = new List<AccountBillingInfo>();

    public virtual ICollection<AccountFile> AccountFiles { get; set; } = new List<AccountFile>();

    public virtual ICollection<AccountOrganizationChart> AccountOrganizationCharts { get; set; } = new List<AccountOrganizationChart>();

    public virtual ICollection<Account> AccountOwners { get; set; } = new List<Account>();

    public virtual ICollection<Account> AccountPrimaryContacts { get; set; } = new List<Account>();

    public virtual ICollection<Activity> ActivityAuthors { get; set; } = new List<Activity>();

    public virtual ICollection<Activity> ActivityContacts { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityFile> ActivityFiles { get; set; } = new List<ActivityFile>();

    public virtual ICollection<Activity> ActivityOrganizers { get; set; } = new List<Activity>();

    public virtual ICollection<Activity> ActivityOwners { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityParticipant> ActivityParticipants { get; set; } = new List<ActivityParticipant>();

    public virtual ICollection<Activity> ActivitySenderContacts { get; set; } = new List<Activity>();

    public virtual AddressType? AddressType { get; set; }

    public virtual ICollection<CallFile> CallFiles { get; set; } = new List<CallFile>();

    public virtual ICollection<Call> Calls { get; set; } = new List<Call>();

    public virtual City? City { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<ContactAddress> ContactAddresses { get; set; } = new List<ContactAddress>();

    public virtual ICollection<ContactAnniversary> ContactAnniversaries { get; set; } = new List<ContactAnniversary>();

    public virtual ICollection<ContactCareer> ContactCareers { get; set; } = new List<ContactCareer>();

    public virtual ICollection<ContactCommunication> ContactCommunications { get; set; } = new List<ContactCommunication>();

    public virtual ICollection<ContactDuplicate> ContactDuplicateEntity1s { get; set; } = new List<ContactDuplicate>();

    public virtual ICollection<ContactDuplicate> ContactDuplicateEntity2s { get; set; } = new List<ContactDuplicate>();

    public virtual ICollection<ContactFile> ContactFileContacts { get; set; } = new List<ContactFile>();

    public virtual ICollection<ContactFile> ContactFileLockedBies { get; set; } = new List<ContactFile>();

    public virtual ICollection<ContactIdentity> ContactIdentities { get; set; } = new List<ContactIdentity>();

    public virtual ICollection<ContactInFolder> ContactInFolders { get; set; } = new List<ContactInFolder>();

    public virtual ICollection<ContactInTag> ContactInTags { get; set; } = new List<ContactInTag>();

    public virtual ICollection<ContactsProductInterest> ContactsProductInterests { get; set; } = new List<ContactsProductInterest>();

    public virtual ICollection<ContentBlockFile> ContentBlockFiles { get; set; } = new List<ContentBlockFile>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<CtisearchResult> CtisearchResults { get; set; } = new List<CtisearchResult>();

    public virtual ICollection<DayOff> DayOffs { get; set; } = new List<DayOff>();

    public virtual ContactDecisionRole? DecisionRole { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettings { get; set; } = new List<EmailFolderColumnValuesSetting>();

    public virtual ICollection<EmailMessageDatum> EmailMessageData { get; set; } = new List<EmailMessageDatum>();

    public virtual ICollection<EmailTemplateFile> EmailTemplateFiles { get; set; } = new List<EmailTemplateFile>();

    public virtual ICollection<Employee> EmployeeContacts { get; set; } = new List<Employee>();

    public virtual ICollection<EmployeeFile> EmployeeFiles { get; set; } = new List<EmployeeFile>();

    public virtual ICollection<Employee> EmployeeOwners { get; set; } = new List<Employee>();

    public virtual ICollection<EnrchFoundContact> EnrchFoundContacts { get; set; } = new List<EnrchFoundContact>();

    public virtual ICollection<EnrchProcessedDatum> EnrchProcessedData { get; set; } = new List<EnrchProcessedDatum>();

    public virtual ICollection<EnrchRejectedDatum> EnrchRejectedData { get; set; } = new List<EnrchRejectedDatum>();

    public virtual ICollection<EsnNotificationSetting> EsnNotificationSettings { get; set; } = new List<EsnNotificationSetting>();

    public virtual ICollection<Esnnotification> Esnnotifications { get; set; } = new List<Esnnotification>();

    public virtual ICollection<ExternalAccessFile> ExternalAccessFiles { get; set; } = new List<ExternalAccessFile>();

    public virtual ICollection<ExternalAccessRequestLog> ExternalAccessRequestLogs { get; set; } = new List<ExternalAccessRequestLog>();

    public virtual ICollection<ExternalAccess> ExternalAccesses { get; set; } = new List<ExternalAccess>();

    public virtual SocialAccount? FacebookAfda { get; set; }

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual ICollection<FormSubmit> FormSubmits { get; set; } = new List<FormSubmit>();

    public virtual Gender? Gender { get; set; }

    public virtual ICollection<GeneratedWebFormFile> GeneratedWebFormFiles { get; set; } = new List<GeneratedWebFormFile>();

    public virtual ICollection<GeneratedWebForm> GeneratedWebForms { get; set; } = new List<GeneratedWebForm>();

    public virtual ICollection<Contact> InverseOwner { get; set; } = new List<Contact>();

    public virtual Job? Job { get; set; }

    public virtual ICollection<KnowledgeBaseFile> KnowledgeBaseFiles { get; set; } = new List<KnowledgeBaseFile>();

    public virtual SysLanguage? Language { get; set; }

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual SocialAccount? LinkedInAfda { get; set; }

    public virtual ICollection<LocationHistory> LocationHistories { get; set; } = new List<LocationHistory>();

    public virtual ICollection<MailboxSettingsFile> MailboxSettingsFiles { get; set; } = new List<MailboxSettingsFile>();

    public virtual ICollection<MkpInstalledAppNewsFile> MkpInstalledAppNewsFiles { get; set; } = new List<MkpInstalledAppNewsFile>();

    public virtual ICollection<MlmodelFile> MlmodelFiles { get; set; } = new List<MlmodelFile>();

    public virtual ICollection<Oauth20AppFile> Oauth20AppFiles { get; set; } = new List<Oauth20AppFile>();

    public virtual ICollection<OmniChatFile> OmniChatFiles { get; set; } = new List<OmniChatFile>();

    public virtual ICollection<OmniChat> OmniChats { get; set; } = new List<OmniChat>();

    public virtual ICollection<OmnichannelMessageFile> OmnichannelMessageFiles { get; set; } = new List<OmnichannelMessageFile>();

    public virtual Contact? Owner { get; set; }

    public virtual SysImage? Photo { get; set; }

    public virtual ICollection<ProductFile> ProductFiles { get; set; } = new List<ProductFile>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<QuickDialUserSetting> QuickDialUserSettings { get; set; } = new List<QuickDialUserSetting>();

    public virtual Region? Region { get; set; }

    public virtual ICollection<Relationship> RelationshipContactAs { get; set; } = new List<Relationship>();

    public virtual ICollection<Relationship> RelationshipContactBs { get; set; } = new List<Relationship>();

    public virtual ICollection<Reminding> RemindingAuthors { get; set; } = new List<Reminding>();

    public virtual ICollection<Reminding> RemindingContacts { get; set; } = new List<Reminding>();

    public virtual ContactSalutationType? SalutationType { get; set; }

    public virtual ICollection<SamlResponse> SamlResponses { get; set; } = new List<SamlResponse>();

    public virtual ICollection<SocialMention> SocialMentions { get; set; } = new List<SocialMention>();

    public virtual ICollection<SysAdminUnit> SysAdminUnits { get; set; } = new List<SysAdminUnit>();

    public virtual ICollection<SysContactRight> SysContactRights { get; set; } = new List<SysContactRight>();

    public virtual ICollection<SysGridPageView> SysGridPageViews { get; set; } = new List<SysGridPageView>();

    public virtual ICollection<SysOperationAuditArch> SysOperationAuditArches { get; set; } = new List<SysOperationAuditArch>();

    public virtual ICollection<SysProcessFile> SysProcessFiles { get; set; } = new List<SysProcessFile>();

    public virtual ICollection<SysProfileDatum> SysProfileData { get; set; } = new List<SysProfileDatum>();

    public virtual ICollection<SysRegistrationDatum> SysRegistrationData { get; set; } = new List<SysRegistrationDatum>();

    public virtual ICollection<SysWorkspace> SysWorkspaces { get; set; } = new List<SysWorkspace>();

    public virtual ICollection<Touch> Touches { get; set; } = new List<Touch>();

    public virtual SocialAccount? TwitterAfda { get; set; }

    public virtual ContactType? Type { get; set; }

    public virtual ICollection<VwProcessLibFile> VwProcessLibFiles { get; set; } = new List<VwProcessLibFile>();

    public virtual ICollection<VwSysProcessFile> VwSysProcessFiles { get; set; } = new List<VwSysProcessFile>();

    public virtual ICollection<WebFormDatum> WebFormData { get; set; } = new List<WebFormDatum>();

    public virtual ICollection<WebServiceV2file> WebServiceV2files { get; set; } = new List<WebServiceV2file>();

    public virtual ICollection<WsysAccount> WsysAccounts { get; set; } = new List<WsysAccount>();
}
