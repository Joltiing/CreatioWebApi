using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessUserTask
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysUserTaskSchemaUid { get; set; }

    public int Position { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? QuickModelEditPageSchemaUid { get; set; }

    public bool IsQuickModel { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? SysImageId { get; set; }

    public virtual SysImage? SysImage { get; set; }
}
