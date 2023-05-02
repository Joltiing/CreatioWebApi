using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Command
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<CommandParam> CommandParams { get; set; } = new List<CommandParam>();

    public virtual ICollection<Macro> Macros { get; set; } = new List<Macro>();

    public virtual ICollection<SysCommandLcz> SysCommandLczs { get; set; } = new List<SysCommandLcz>();
}
