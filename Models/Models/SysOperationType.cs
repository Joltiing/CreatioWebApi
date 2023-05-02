using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysOperationType
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

    public virtual ICollection<SysOperationAuditArch> SysOperationAuditArches { get; set; } = new List<SysOperationAuditArch>();

    public virtual ICollection<SysOperationAudit> SysOperationAudits { get; set; } = new List<SysOperationAudit>();

    public virtual ICollection<SysOperationTypeLcz> SysOperationTypeLczs { get; set; } = new List<SysOperationTypeLcz>();
}
