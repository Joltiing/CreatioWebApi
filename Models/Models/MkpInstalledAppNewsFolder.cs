using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MkpInstalledAppNewsFolder
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

    public virtual ICollection<MkpInstalledAppNewsFolder> InverseParent { get; set; } = new List<MkpInstalledAppNewsFolder>();

    public virtual ICollection<MkpInstalledAppNewsInFolder> MkpInstalledAppNewsInFolders { get; set; } = new List<MkpInstalledAppNewsInFolder>();

    public virtual MkpInstalledAppNewsFolder? Parent { get; set; }

    public virtual ICollection<SysMkpInstAppNewsFolderLcz> SysMkpInstAppNewsFolderLczs { get; set; } = new List<SysMkpInstAppNewsFolderLcz>();

    public virtual ICollection<SysMkpInstAppNewsFolderRight> SysMkpInstAppNewsFolderRights { get; set; } = new List<SysMkpInstAppNewsFolderRight>();
}
