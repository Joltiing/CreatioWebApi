using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FileFolder
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

    public virtual ICollection<FileInFolder> FileInFolders { get; set; } = new List<FileInFolder>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<FileFolder> InverseParent { get; set; } = new List<FileFolder>();

    public virtual FileFolder? Parent { get; set; }

    public virtual ICollection<SysFileFolderLcz> SysFileFolderLczs { get; set; } = new List<SysFileFolderLcz>();
}
