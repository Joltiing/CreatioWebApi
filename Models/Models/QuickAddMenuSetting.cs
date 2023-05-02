using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class QuickAddMenuSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public Guid? SysAdminUnitId { get; set; }

    public int Position { get; set; }

    public virtual ICollection<QuickAddMenuItem> QuickAddMenuItems { get; set; } = new List<QuickAddMenuItem>();

    public virtual SysAdminUnit? SysAdminUnit { get; set; }

    public virtual ICollection<SysQuickAddMenuSettingsLcz> SysQuickAddMenuSettingsLczs { get; set; } = new List<SysQuickAddMenuSettingsLcz>();
}
