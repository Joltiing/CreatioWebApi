using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminOperationFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public byte[]? SearchData { get; set; }

    public Guid? FolderTypeId { get; set; }

    public int ProcessListeners { get; set; }

    public int OptimizationType { get; set; }

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<SysAdminOperationFolder> InverseParent { get; set; } = new List<SysAdminOperationFolder>();

    public virtual SysAdminOperationFolder? Parent { get; set; }

    public virtual ICollection<SysAdminOperationFolderLcz> SysAdminOperationFolderLczs { get; set; } = new List<SysAdminOperationFolderLcz>();

    public virtual ICollection<SysAdminOperation> SysAdminOperations { get; set; } = new List<SysAdminOperation>();
}
