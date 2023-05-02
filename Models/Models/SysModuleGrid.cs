using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleGrid
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysModuleEntityId { get; set; }

    public bool HasAllItemsView { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysPageSchemaUid { get; set; }

    public virtual ICollection<SysModuleDetail> SysModuleDetails { get; set; } = new List<SysModuleDetail>();

    public virtual ICollection<SysModuleEditDetail> SysModuleEditDetails { get; set; } = new List<SysModuleEditDetail>();

    public virtual SysModuleEntity? SysModuleEntity { get; set; }

    public virtual ICollection<SysModuleGridView> SysModuleGridViews { get; set; } = new List<SysModuleGridView>();

    public virtual ICollection<SysModulePrimaryGrid> SysModulePrimaryGrids { get; set; } = new List<SysModulePrimaryGrid>();
}
