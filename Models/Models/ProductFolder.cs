using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ProductFolder
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

    public virtual ICollection<ProductFolder> InverseParent { get; set; } = new List<ProductFolder>();

    public virtual ProductFolder? Parent { get; set; }

    public virtual ICollection<ProductInFolder> ProductInFolders { get; set; } = new List<ProductInFolder>();

    public virtual ICollection<SysProductFolderLcz> SysProductFolderLczs { get; set; } = new List<SysProductFolderLcz>();
}
