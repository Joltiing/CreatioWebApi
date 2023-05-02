using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSubProcessInProcess
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? HostProcessId { get; set; }

    public Guid? ParentProcessId { get; set; }

    public Guid? SubProcessId { get; set; }

    public Guid? ParentSubProcessId { get; set; }

    public Guid? ActiveSubProcessId { get; set; }
}
