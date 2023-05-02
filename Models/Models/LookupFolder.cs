using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LookupFolder
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Description { get; set; } = null!;

    public Guid? FolderTypeId { get; set; }

    public byte[]? SearchData { get; set; }

    public int OptimizationType { get; set; }

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<LookupFolder> InverseParent { get; set; } = new List<LookupFolder>();

    public virtual ICollection<LookupInFolder> LookupInFolders { get; set; } = new List<LookupInFolder>();

    public virtual LookupFolder? Parent { get; set; }

    public virtual ICollection<SysLookupFolderLcz> SysLookupFolderLczs { get; set; } = new List<SysLookupFolderLcz>();
}
