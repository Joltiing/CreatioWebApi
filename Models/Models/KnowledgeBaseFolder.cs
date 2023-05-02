using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class KnowledgeBaseFolder
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

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<KnowledgeBaseFolder> InverseParent { get; set; } = new List<KnowledgeBaseFolder>();

    public virtual ICollection<KnowledgeBaseInFolder> KnowledgeBaseInFolders { get; set; } = new List<KnowledgeBaseInFolder>();

    public virtual KnowledgeBaseFolder? Parent { get; set; }

    public virtual ICollection<SysKnowledgeBaseFolderLcz> SysKnowledgeBaseFolderLczs { get; set; } = new List<SysKnowledgeBaseFolderLcz>();

    public virtual ICollection<SysKnowledgeBaseFolderRight> SysKnowledgeBaseFolderRights { get; set; } = new List<SysKnowledgeBaseFolderRight>();
}
