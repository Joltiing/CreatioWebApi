using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessStatus
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Value { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysPrcElHistoryLog> SysPrcElHistoryLogs { get; set; } = new List<SysPrcElHistoryLog>();

    public virtual ICollection<SysPrcHistoryLog> SysPrcHistoryLogs { get; set; } = new List<SysPrcHistoryLog>();

    public virtual ICollection<SysProcessElementLog> SysProcessElementLogs { get; set; } = new List<SysProcessElementLog>();

    public virtual ICollection<SysProcessLog> SysProcessLogs { get; set; } = new List<SysProcessLog>();

    public virtual ICollection<SysProcessStatusLcz> SysProcessStatusLczs { get; set; } = new List<SysProcessStatusLcz>();
}
