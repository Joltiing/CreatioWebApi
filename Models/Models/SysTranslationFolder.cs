using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysTranslationFolder
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

    public virtual ICollection<SysTranslationFolder> InverseParent { get; set; } = new List<SysTranslationFolder>();

    public virtual SysTranslationFolder? Parent { get; set; }

    public virtual ICollection<SysTranslationFolderLcz> SysTranslationFolderLczs { get; set; } = new List<SysTranslationFolderLcz>();

    public virtual ICollection<SysTranslationFolderRight> SysTranslationFolderRights { get; set; } = new List<SysTranslationFolderRight>();

    public virtual ICollection<SysTranslationInFolder> SysTranslationInFolders { get; set; } = new List<SysTranslationInFolder>();
}
