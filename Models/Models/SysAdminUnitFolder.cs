using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminUnitFolder
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

    public virtual ICollection<SysAdminUnitFolder> InverseParent { get; set; } = new List<SysAdminUnitFolder>();

    public virtual SysAdminUnitFolder? Parent { get; set; }

    public virtual ICollection<SysAdminUnitFolderLcz> SysAdminUnitFolderLczs { get; set; } = new List<SysAdminUnitFolderLcz>();

    public virtual ICollection<SysAdminUnitInFolder> SysAdminUnitInFolders { get; set; } = new List<SysAdminUnitInFolder>();
}
