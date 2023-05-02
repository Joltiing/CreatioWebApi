using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailTemplateFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public Guid? FolderTypeId { get; set; }

    public byte[]? SearchData { get; set; }

    public int ProcessListeners { get; set; }

    public int OptimizationType { get; set; }

    public virtual ICollection<EmailTemplateInFolder> EmailTemplateInFolders { get; set; } = new List<EmailTemplateInFolder>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<EmailTemplateFolder> InverseParent { get; set; } = new List<EmailTemplateFolder>();

    public virtual EmailTemplateFolder? Parent { get; set; }

    public virtual ICollection<SysEmailTemplateFolderLcz> SysEmailTemplateFolderLczs { get; set; } = new List<SysEmailTemplateFolderLcz>();

    public virtual ICollection<SysEmailTemplateFolderRight> SysEmailTemplateFolderRights { get; set; } = new List<SysEmailTemplateFolderRight>();
}
