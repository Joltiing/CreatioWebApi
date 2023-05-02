using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class CallFolder
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

    public virtual ICollection<CallInFolder> CallInFolders { get; set; } = new List<CallInFolder>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<CallFolder> InverseParent { get; set; } = new List<CallFolder>();

    public virtual CallFolder? Parent { get; set; }

    public virtual ICollection<SysCallFolderLcz> SysCallFolderLczs { get; set; } = new List<SysCallFolderLcz>();
}
