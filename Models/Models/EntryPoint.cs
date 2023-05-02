using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EntryPoint
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysProcessElementDataId { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public Guid? EntityId { get; set; }

    public bool IsActive { get; set; }

    public virtual SysProcessElementDatum? SysProcessElementData { get; set; }
}
