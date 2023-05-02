using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysOperationAuditArch
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? TypeId { get; set; }

    public DateTime? Date { get; set; }

    public Guid? ResultId { get; set; }

    public Guid? OwnerId { get; set; }

    public string ClientIp { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual Contact? Owner { get; set; }

    public virtual SysOperationResult? Result { get; set; }

    public virtual SysOperationType? Type { get; set; }
}
