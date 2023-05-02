using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Caption { get; set; } = null!;

    public byte[]? Image { get; set; }

    public int Position { get; set; }

    public Guid? ParentId { get; set; }

    public int ProcessListeners { get; set; }

    public string Location { get; set; } = null!;

    public virtual City? Parent { get; set; }

    public virtual ICollection<SysModuleFolderLczOld> SysModuleFolderLczOlds { get; set; } = new List<SysModuleFolderLczOld>();

    public virtual ICollection<SysModuleFolderLcz> SysModuleFolderLczs { get; set; } = new List<SysModuleFolderLcz>();

    public virtual ICollection<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderSubSysModuleFolders { get; set; } = new List<SysModuleInSysModuleFolder>();

    public virtual ICollection<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderSysModuleFolders { get; set; } = new List<SysModuleInSysModuleFolder>();
}
