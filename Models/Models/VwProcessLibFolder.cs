using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwProcessLibFolder
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

    public virtual ICollection<VwProcessLibFolder> InverseParent { get; set; } = new List<VwProcessLibFolder>();

    public virtual VwProcessLibFolder? Parent { get; set; }

    public virtual ICollection<SysVwProcessLibFolderLcz> SysVwProcessLibFolderLczs { get; set; } = new List<SysVwProcessLibFolderLcz>();

    public virtual ICollection<VwProcessLibInFolder> VwProcessLibInFolders { get; set; } = new List<VwProcessLibInFolder>();
}
