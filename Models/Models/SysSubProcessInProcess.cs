using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSubProcessInProcess
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ProcessUid { get; set; }

    public Guid? ParentProcessUid { get; set; }

    public Guid? SubProcessUid { get; set; }

    public Guid? ParentSubProcessUid { get; set; }

    public int ProcessListeners { get; set; }
}
