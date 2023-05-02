using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLookupFolder
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

    public virtual ICollection<SysLookupFolder> InverseParent { get; set; } = new List<SysLookupFolder>();

    public virtual SysLookupFolder? Parent { get; set; }

    public virtual ICollection<SysLookupFolderRight> SysLookupFolderRights { get; set; } = new List<SysLookupFolderRight>();

    public virtual ICollection<SysLookup> SysLookups { get; set; } = new List<SysLookup>();

    public virtual ICollection<VwSysLookupInFolder> VwSysLookupInFolders { get; set; } = new List<VwSysLookupInFolder>();
}
