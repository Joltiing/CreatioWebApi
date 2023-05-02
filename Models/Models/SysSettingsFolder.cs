using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSettingsFolder
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

    public virtual ICollection<SysSettingsFolder> InverseParent { get; set; } = new List<SysSettingsFolder>();

    public virtual SysSettingsFolder? Parent { get; set; }

    public virtual ICollection<SysSetting> SysSettings { get; set; } = new List<SysSetting>();

    public virtual ICollection<SysSettingsFolderLcz> SysSettingsFolderLczs { get; set; } = new List<SysSettingsFolderLcz>();

    public virtual ICollection<SysSettingsInFolder> SysSettingsInFolders { get; set; } = new List<SysSettingsInFolder>();
}
