using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FolderType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int Order { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ImageId { get; set; }

    public virtual ICollection<AccountFolder> AccountFolders { get; set; } = new List<AccountFolder>();

    public virtual ICollection<ActivityFolder> ActivityFolders { get; set; } = new List<ActivityFolder>();

    public virtual ICollection<CallFolder> CallFolders { get; set; } = new List<CallFolder>();

    public virtual ICollection<ContactFolder> ContactFolders { get; set; } = new List<ContactFolder>();

    public virtual ICollection<DuplicatesRuleFolder> DuplicatesRuleFolders { get; set; } = new List<DuplicatesRuleFolder>();

    public virtual ICollection<EmailTemplateFolder> EmailTemplateFolders { get; set; } = new List<EmailTemplateFolder>();

    public virtual ICollection<EmployeeFolder> EmployeeFolders { get; set; } = new List<EmployeeFolder>();

    public virtual ICollection<ExternalAccessFolder> ExternalAccessFolders { get; set; } = new List<ExternalAccessFolder>();

    public virtual ICollection<FileFolder> FileFolders { get; set; } = new List<FileFolder>();

    public virtual ICollection<GeneratedWebFormFolder> GeneratedWebFormFolders { get; set; } = new List<GeneratedWebFormFolder>();

    public virtual SysImage? Image { get; set; }

    public virtual ICollection<KnowledgeBaseFolder> KnowledgeBaseFolders { get; set; } = new List<KnowledgeBaseFolder>();

    public virtual ICollection<LookupFolder> LookupFolders { get; set; } = new List<LookupFolder>();

    public virtual ICollection<MkpInstalledAppNewsFolder> MkpInstalledAppNewsFolders { get; set; } = new List<MkpInstalledAppNewsFolder>();

    public virtual ICollection<MlmodelFolder> MlmodelFolders { get; set; } = new List<MlmodelFolder>();

    public virtual ICollection<Oauth20AppFolder> Oauth20AppFolders { get; set; } = new List<Oauth20AppFolder>();

    public virtual ICollection<OmniChatFolder> OmniChatFolders { get; set; } = new List<OmniChatFolder>();

    public virtual ICollection<ProductFolder> ProductFolders { get; set; } = new List<ProductFolder>();

    public virtual ICollection<ReportFolder> ReportFolders { get; set; } = new List<ReportFolder>();

    public virtual ICollection<SocialChannelFolder> SocialChannelFolders { get; set; } = new List<SocialChannelFolder>();

    public virtual ICollection<SysAdminOperationFolder> SysAdminOperationFolders { get; set; } = new List<SysAdminOperationFolder>();

    public virtual ICollection<SysAdminUnitFolder> SysAdminUnitFolders { get; set; } = new List<SysAdminUnitFolder>();

    public virtual ICollection<SysFolderTypeLcz> SysFolderTypeLczs { get; set; } = new List<SysFolderTypeLcz>();

    public virtual ICollection<SysLookupFolder> SysLookupFolders { get; set; } = new List<SysLookupFolder>();

    public virtual ICollection<SysProcessLogFolder> SysProcessLogFolders { get; set; } = new List<SysProcessLogFolder>();

    public virtual ICollection<SysProcessUserTaskFolder> SysProcessUserTaskFolders { get; set; } = new List<SysProcessUserTaskFolder>();

    public virtual ICollection<SysSettingsFolder> SysSettingsFolders { get; set; } = new List<SysSettingsFolder>();

    public virtual ICollection<SysTranslationFolder> SysTranslationFolders { get; set; } = new List<SysTranslationFolder>();

    public virtual ICollection<VwProcessLibFolder> VwProcessLibFolders { get; set; } = new List<VwProcessLibFolder>();

    public virtual ICollection<VwSysDcmLibFolder> VwSysDcmLibFolders { get; set; } = new List<VwSysDcmLibFolder>();

    public virtual ICollection<VwSysProcessFolder> VwSysProcessFolders { get; set; } = new List<VwSysProcessFolder>();

    public virtual ICollection<WebServiceV2folder> WebServiceV2folders { get; set; } = new List<WebServiceV2folder>();
}
