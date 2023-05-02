using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class GeneratedWebFormFolder
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

    public virtual ICollection<GeneratedWebFormInFolder> GeneratedWebFormInFolders { get; set; } = new List<GeneratedWebFormInFolder>();

    public virtual ICollection<GeneratedWebFormFolder> InverseParent { get; set; } = new List<GeneratedWebFormFolder>();

    public virtual GeneratedWebFormFolder? Parent { get; set; }

    public virtual ICollection<SysGeneratedWebFormFolderLcz> SysGeneratedWebFormFolderLczs { get; set; } = new List<SysGeneratedWebFormFolderLcz>();
}
