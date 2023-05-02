using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSspentitySchemaAccessList
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public int ProcessListeners { get; set; }

    public bool IsPreset { get; set; }
}
