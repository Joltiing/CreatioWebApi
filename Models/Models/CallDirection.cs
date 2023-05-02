using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class CallDirection
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? ImageId { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<Call> Calls { get; set; } = new List<Call>();

    public virtual SysImage? Image { get; set; }

    public virtual ICollection<SysActiveCall> SysActiveCalls { get; set; } = new List<SysActiveCall>();

    public virtual ICollection<SysCallDirectionLcz> SysCallDirectionLczs { get; set; } = new List<SysCallDirectionLcz>();
}
