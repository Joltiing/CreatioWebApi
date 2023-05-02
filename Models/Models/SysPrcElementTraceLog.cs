using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcElementTraceLog
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysProcessElementLogId { get; set; }

    public int TraceEvent { get; set; }

    public string ElementData { get; set; } = null!;

    public string ProcessData { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string ClientIp { get; set; } = null!;
}
