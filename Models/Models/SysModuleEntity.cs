using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleEntity
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? TypeColumnUid { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysEntitySchemaUid { get; set; }

    public virtual ICollection<PortalSysModule> PortalSysModules { get; set; } = new List<PortalSysModule>();

    public virtual ICollection<SysDcmSetting> SysDcmSettings { get; set; } = new List<SysDcmSetting>();

    public virtual ICollection<SysModuleDcmSetting> SysModuleDcmSettings { get; set; } = new List<SysModuleDcmSetting>();

    public virtual ICollection<SysModuleEdit> SysModuleEdits { get; set; } = new List<SysModuleEdit>();

    public virtual ICollection<SysModuleEntityInPortal> SysModuleEntityInPortals { get; set; } = new List<SysModuleEntityInPortal>();

    public virtual ICollection<SysModuleGrid> SysModuleGrids { get; set; } = new List<SysModuleGrid>();

    public virtual ICollection<SysModule> SysModules { get; set; } = new List<SysModule>();
}
