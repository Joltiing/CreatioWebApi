using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysSspentitySchemaAccessList
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public Guid? WorkspaceId { get; set; }

    public string EntitySchemaCaption { get; set; } = null!;

    public string EntitySchemaName { get; set; } = null!;

    public Guid SysSchemaId { get; set; }
}
