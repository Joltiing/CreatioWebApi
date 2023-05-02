using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FileType
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

    public virtual ICollection<AccountFile> AccountFiles { get; set; } = new List<AccountFile>();

    public virtual ICollection<ActivityFile> ActivityFiles { get; set; } = new List<ActivityFile>();

    public virtual ICollection<CallFile> CallFiles { get; set; } = new List<CallFile>();

    public virtual ICollection<ContactFile> ContactFiles { get; set; } = new List<ContactFile>();

    public virtual ICollection<ContentBlockFile> ContentBlockFiles { get; set; } = new List<ContentBlockFile>();

    public virtual ICollection<EmailTemplateFile> EmailTemplateFiles { get; set; } = new List<EmailTemplateFile>();

    public virtual ICollection<EmployeeFile> EmployeeFiles { get; set; } = new List<EmployeeFile>();

    public virtual ICollection<ExternalAccessFile> ExternalAccessFiles { get; set; } = new List<ExternalAccessFile>();

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual ICollection<GeneratedWebFormFile> GeneratedWebFormFiles { get; set; } = new List<GeneratedWebFormFile>();

    public virtual ICollection<KnowledgeBaseFile> KnowledgeBaseFiles { get; set; } = new List<KnowledgeBaseFile>();

    public virtual ICollection<MailboxSettingsFile> MailboxSettingsFiles { get; set; } = new List<MailboxSettingsFile>();

    public virtual ICollection<MkpInstalledAppNewsFile> MkpInstalledAppNewsFiles { get; set; } = new List<MkpInstalledAppNewsFile>();

    public virtual ICollection<MlmodelFile> MlmodelFiles { get; set; } = new List<MlmodelFile>();

    public virtual ICollection<Oauth20AppFile> Oauth20AppFiles { get; set; } = new List<Oauth20AppFile>();

    public virtual ICollection<OmniChatFile> OmniChatFiles { get; set; } = new List<OmniChatFile>();

    public virtual ICollection<OmnichannelMessageFile> OmnichannelMessageFiles { get; set; } = new List<OmnichannelMessageFile>();

    public virtual ICollection<ProductFile> ProductFiles { get; set; } = new List<ProductFile>();

    public virtual ICollection<SysFileTypeLcz> SysFileTypeLczs { get; set; } = new List<SysFileTypeLcz>();

    public virtual ICollection<SysProcessFile> SysProcessFiles { get; set; } = new List<SysProcessFile>();

    public virtual ICollection<VwProcessLibFile> VwProcessLibFiles { get; set; } = new List<VwProcessLibFile>();

    public virtual ICollection<VwSysProcessFile> VwSysProcessFiles { get; set; } = new List<VwSysProcessFile>();

    public virtual ICollection<WebServiceV2file> WebServiceV2files { get; set; } = new List<WebServiceV2file>();
}
