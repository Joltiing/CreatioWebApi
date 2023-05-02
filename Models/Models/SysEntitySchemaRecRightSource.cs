using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEntitySchemaRecRightSource
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysAccountAlternativeNameRight> SysAccountAlternativeNameRights { get; set; } = new List<SysAccountAlternativeNameRight>();

    public virtual ICollection<SysAccountFolderRight> SysAccountFolderRights { get; set; } = new List<SysAccountFolderRight>();

    public virtual ICollection<SysAccountRight> SysAccountRights { get; set; } = new List<SysAccountRight>();

    public virtual ICollection<SysAccountTagRight> SysAccountTagRights { get; set; } = new List<SysAccountTagRight>();

    public virtual ICollection<SysActivityFolderRight> SysActivityFolderRights { get; set; } = new List<SysActivityFolderRight>();

    public virtual ICollection<SysActivityRight> SysActivityRights { get; set; } = new List<SysActivityRight>();

    public virtual ICollection<SysActivityTagRight> SysActivityTagRights { get; set; } = new List<SysActivityTagRight>();

    public virtual ICollection<SysCallTagRight> SysCallTagRights { get; set; } = new List<SysCallTagRight>();

    public virtual ICollection<SysContactFolderRight> SysContactFolderRights { get; set; } = new List<SysContactFolderRight>();

    public virtual ICollection<SysContactRight> SysContactRights { get; set; } = new List<SysContactRight>();

    public virtual ICollection<SysContactTagRight> SysContactTagRights { get; set; } = new List<SysContactTagRight>();

    public virtual ICollection<SysContentBlockInTagRight> SysContentBlockInTagRights { get; set; } = new List<SysContentBlockInTagRight>();

    public virtual ICollection<SysContentBlockTagRight> SysContentBlockTagRights { get; set; } = new List<SysContentBlockTagRight>();

    public virtual ICollection<SysDashboardRight> SysDashboardRights { get; set; } = new List<SysDashboardRight>();

    public virtual ICollection<SysDisplayDateFormatRight> SysDisplayDateFormatRights { get; set; } = new List<SysDisplayDateFormatRight>();

    public virtual ICollection<SysDuplicatesRuleTagRight> SysDuplicatesRuleTagRights { get; set; } = new List<SysDuplicatesRuleTagRight>();

    public virtual ICollection<SysEmailTemplateFolderRight> SysEmailTemplateFolderRights { get; set; } = new List<SysEmailTemplateFolderRight>();

    public virtual ICollection<SysEmailTemplateInFolderRight> SysEmailTemplateInFolderRights { get; set; } = new List<SysEmailTemplateInFolderRight>();

    public virtual ICollection<SysEmailTemplateInTagRight> SysEmailTemplateInTagRights { get; set; } = new List<SysEmailTemplateInTagRight>();

    public virtual ICollection<SysEmailTemplateTagRight> SysEmailTemplateTagRights { get; set; } = new List<SysEmailTemplateTagRight>();

    public virtual ICollection<SysEmployeeFolderRight> SysEmployeeFolderRights { get; set; } = new List<SysEmployeeFolderRight>();

    public virtual ICollection<SysEmployeeTagRight> SysEmployeeTagRights { get; set; } = new List<SysEmployeeTagRight>();

    public virtual ICollection<SysEntitySchRecRightSourceLcz> SysEntitySchRecRightSourceLczs { get; set; } = new List<SysEntitySchRecRightSourceLcz>();

    public virtual ICollection<SysExternalAccessFolderRight> SysExternalAccessFolderRights { get; set; } = new List<SysExternalAccessFolderRight>();

    public virtual ICollection<SysExternalAccessInFolderRight> SysExternalAccessInFolderRights { get; set; } = new List<SysExternalAccessInFolderRight>();

    public virtual ICollection<SysExternalAccessInTagRight> SysExternalAccessInTagRights { get; set; } = new List<SysExternalAccessInTagRight>();

    public virtual ICollection<SysExternalAccessTagRight> SysExternalAccessTagRights { get; set; } = new List<SysExternalAccessTagRight>();

    public virtual ICollection<SysGeneratedWebFormTagRight> SysGeneratedWebFormTagRights { get; set; } = new List<SysGeneratedWebFormTagRight>();

    public virtual ICollection<SysImportSessionRight> SysImportSessionRights { get; set; } = new List<SysImportSessionRight>();

    public virtual ICollection<SysKnowledgeBaseFolderRight> SysKnowledgeBaseFolderRights { get; set; } = new List<SysKnowledgeBaseFolderRight>();

    public virtual ICollection<SysKnowledgeBaseRight> SysKnowledgeBaseRights { get; set; } = new List<SysKnowledgeBaseRight>();

    public virtual ICollection<SysKnowledgeBaseTagV2right> SysKnowledgeBaseTagV2rights { get; set; } = new List<SysKnowledgeBaseTagV2right>();

    public virtual ICollection<SysLookupFolderRight> SysLookupFolderRights { get; set; } = new List<SysLookupFolderRight>();

    public virtual ICollection<SysLookupTagRight> SysLookupTagRights { get; set; } = new List<SysLookupTagRight>();

    public virtual ICollection<SysMailboxSyncSettingsRight> SysMailboxSyncSettingsRights { get; set; } = new List<SysMailboxSyncSettingsRight>();

    public virtual ICollection<SysMkpInstAppNewsFolderRight> SysMkpInstAppNewsFolderRights { get; set; } = new List<SysMkpInstAppNewsFolderRight>();

    public virtual ICollection<SysMkpInstAppNewsInFolderRight> SysMkpInstAppNewsInFolderRights { get; set; } = new List<SysMkpInstAppNewsInFolderRight>();

    public virtual ICollection<SysMkpInstAppNewsInTagRight> SysMkpInstAppNewsInTagRights { get; set; } = new List<SysMkpInstAppNewsInTagRight>();

    public virtual ICollection<SysMkpInstalledAppNewsTagRight> SysMkpInstalledAppNewsTagRights { get; set; } = new List<SysMkpInstalledAppNewsTagRight>();

    public virtual ICollection<SysMlmodelTagRight> SysMlmodelTagRights { get; set; } = new List<SysMlmodelTagRight>();

    public virtual ICollection<SysOauth20AppFolderRight> SysOauth20AppFolderRights { get; set; } = new List<SysOauth20AppFolderRight>();

    public virtual ICollection<SysOauth20AppInFolderRight> SysOauth20AppInFolderRights { get; set; } = new List<SysOauth20AppInFolderRight>();

    public virtual ICollection<SysOauth20AppInTagRight> SysOauth20AppInTagRights { get; set; } = new List<SysOauth20AppInTagRight>();

    public virtual ICollection<SysOauth20AppTagRight> SysOauth20AppTagRights { get; set; } = new List<SysOauth20AppTagRight>();

    public virtual ICollection<SysOmniChatFolderRight> SysOmniChatFolderRights { get; set; } = new List<SysOmniChatFolderRight>();

    public virtual ICollection<SysOmniChatInFolderRight> SysOmniChatInFolderRights { get; set; } = new List<SysOmniChatInFolderRight>();

    public virtual ICollection<SysOmniChatInTagRight> SysOmniChatInTagRights { get; set; } = new List<SysOmniChatInTagRight>();

    public virtual ICollection<SysOmniChatTagRight> SysOmniChatTagRights { get; set; } = new List<SysOmniChatTagRight>();

    public virtual ICollection<SysProcessLogFolderRight> SysProcessLogFolderRights { get; set; } = new List<SysProcessLogFolderRight>();

    public virtual ICollection<SysProductRight> SysProductRights { get; set; } = new List<SysProductRight>();

    public virtual ICollection<SysProductTagRight> SysProductTagRights { get; set; } = new List<SysProductTagRight>();

    public virtual ICollection<SysReportRight> SysReportRights { get; set; } = new List<SysReportRight>();

    public virtual ICollection<SysSocialChannelFolderRight> SysSocialChannelFolderRights { get; set; } = new List<SysSocialChannelFolderRight>();

    public virtual ICollection<SysSocialChannelRight> SysSocialChannelRights { get; set; } = new List<SysSocialChannelRight>();

    public virtual ICollection<SysSocialChannelTagRight> SysSocialChannelTagRights { get; set; } = new List<SysSocialChannelTagRight>();

    public virtual ICollection<SysSocialSubscriptionRight> SysSocialSubscriptionRights { get; set; } = new List<SysSocialSubscriptionRight>();

    public virtual ICollection<SysTranslationFolderRight> SysTranslationFolderRights { get; set; } = new List<SysTranslationFolderRight>();

    public virtual ICollection<SysTranslationTagRight> SysTranslationTagRights { get; set; } = new List<SysTranslationTagRight>();

    public virtual ICollection<SysVwSysProcessFolderRight> SysVwSysProcessFolderRights { get; set; } = new List<SysVwSysProcessFolderRight>();

    public virtual ICollection<SysWebServiceV2folderRight> SysWebServiceV2folderRights { get; set; } = new List<SysWebServiceV2folderRight>();

    public virtual ICollection<SysWebServiceV2inFolderRight> SysWebServiceV2inFolderRights { get; set; } = new List<SysWebServiceV2inFolderRight>();

    public virtual ICollection<SysWebServiceV2inTagRight> SysWebServiceV2inTagRights { get; set; } = new List<SysWebServiceV2inTagRight>();

    public virtual ICollection<SysWebServiceV2tagRight> SysWebServiceV2tagRights { get; set; } = new List<SysWebServiceV2tagRight>();

    public virtual ICollection<SysWsysAccountTagRight> SysWsysAccountTagRights { get; set; } = new List<SysWsysAccountTagRight>();
}
