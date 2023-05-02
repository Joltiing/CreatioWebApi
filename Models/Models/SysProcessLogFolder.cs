using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessLogFolder
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

    public virtual ICollection<SysProcessLogFolder> InverseParent { get; set; } = new List<SysProcessLogFolder>();

    public virtual SysProcessLogFolder? Parent { get; set; }

    public virtual ICollection<SysProcessLogFolderLcz> SysProcessLogFolderLczs { get; set; } = new List<SysProcessLogFolderLcz>();

    public virtual ICollection<SysProcessLogFolderRight> SysProcessLogFolderRights { get; set; } = new List<SysProcessLogFolderRight>();

    public virtual ICollection<SysProcessLogInFolder> SysProcessLogInFolders { get; set; } = new List<SysProcessLogInFolder>();
}
