using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysProcessEntity
{
    public Guid Id { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? SysProcessId { get; set; }

    public Guid? EntityId { get; set; }

    public string EntityDisplayValue { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid SysSchemaId { get; set; }

    public string ReferenceSchemaName { get; set; } = null!;

    public Guid? SysWorkspaceId { get; set; }

    public bool? Archived { get; set; }
}
