using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysStartTimerInProcess
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ProcessUid { get; set; }

    public int ExpressionType { get; set; }

    public Guid? ProcessElementUid { get; set; }

    public int ProcessListeners { get; set; }
}
