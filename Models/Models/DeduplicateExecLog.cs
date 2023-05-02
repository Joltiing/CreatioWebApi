using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DeduplicateExecLog
{
    public Guid Id { get; set; }

    public string ProcedureName { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public DateTime? ExecutedOn { get; set; }

    public DateTime? CompletedOn { get; set; }

    public int SqlErrorCode { get; set; }

    public string SqlErrorMessage { get; set; } = null!;

    public virtual ICollection<DeduplicateExecLocker> DeduplicateExecLockers { get; set; } = new List<DeduplicateExecLocker>();
}
