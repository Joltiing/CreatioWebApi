using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OperatorSession
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysUserId { get; set; }

    public DateTime? SessionStartDate { get; set; }

    public DateTime? SessionEndDate { get; set; }

    public Guid? OperatorStateId { get; set; }

    public int Duration { get; set; }

    public virtual OperatorState? OperatorState { get; set; }

    public virtual SysAdminUnit? SysUser { get; set; }
}
