using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessUserTaskFolder
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

    public virtual ICollection<SysProcessUserTaskFolder> InverseParent { get; set; } = new List<SysProcessUserTaskFolder>();

    public virtual SysProcessUserTaskFolder? Parent { get; set; }

    public virtual ICollection<SysProcessUserTaskFolderLcz> SysProcessUserTaskFolderLczs { get; set; } = new List<SysProcessUserTaskFolderLcz>();

    public virtual ICollection<SysProcessUserTaskInFolder> SysProcessUserTaskInFolders { get; set; } = new List<SysProcessUserTaskInFolder>();
}
