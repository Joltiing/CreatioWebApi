using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string ValueTypeName { get; set; } = null!;

    public Guid? SysFolderId { get; set; }

    public bool IsPersonal { get; set; }

    public bool IsCacheable { get; set; }

    public Guid? ReferenceSchemaUid { get; set; }

    public bool IsSspavailable { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysSettingsFolder? SysFolder { get; set; }

    public virtual ICollection<SysSettingsInFolder> SysSettingsInFolders { get; set; } = new List<SysSettingsInFolder>();

    public virtual ICollection<SysSettingsLcz> SysSettingsLczs { get; set; } = new List<SysSettingsLcz>();

    public virtual ICollection<SysSettingsReferenceSchema> SysSettingsReferenceSchemas { get; set; } = new List<SysSettingsReferenceSchema>();

    public virtual ICollection<SysSettingsValue> SysSettingsValues { get; set; } = new List<SysSettingsValue>();
}
