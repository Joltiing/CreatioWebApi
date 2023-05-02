using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Macro
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? CommandId { get; set; }

    public string Name { get; set; } = null!;

    public Guid? MainParamId { get; set; }

    public Guid? AdditionalParamId { get; set; }

    public string AdditionalParamValue { get; set; } = null!;

    public string MainParamType { get; set; } = null!;

    public bool IsShared { get; set; }

    public virtual AdditionalParam? AdditionalParam { get; set; }

    public virtual Command? Command { get; set; }

    public virtual MainParam? MainParam { get; set; }

    public virtual ICollection<SysMacrosLcz> SysMacrosLczs { get; set; } = new List<SysMacrosLcz>();
}
