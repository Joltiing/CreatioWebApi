using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class QuickAddMenuItem
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public Guid? SysModuleEditId { get; set; }

    public Guid? QuickAddMenuSettingsId { get; set; }

    public int Position { get; set; }

    public string Description { get; set; } = null!;

    public Guid? ModuleUid { get; set; }

    public virtual QuickAddMenuSetting? QuickAddMenuSettings { get; set; }

    public virtual SysModuleEdit? SysModuleEdit { get; set; }

    public virtual ICollection<SysQuickAddMenuItemLcz> SysQuickAddMenuItemLczs { get; set; } = new List<SysQuickAddMenuItemLcz>();
}
