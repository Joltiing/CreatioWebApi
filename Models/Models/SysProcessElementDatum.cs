using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessElementDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SchemaElementUid { get; set; }

    public Guid? SysProcessId { get; set; }

    public byte[]? PropertiesData { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? SchemaUid { get; set; }

    public int Status { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<EntryPoint> EntryPoints { get; set; } = new List<EntryPoint>();

    public virtual ICollection<SysEntityCommonPrcEl> SysEntityCommonPrcEls { get; set; } = new List<SysEntityCommonPrcEl>();

    public virtual SysProcessDatum? SysProcess { get; set; }

    public virtual ICollection<SysProcessIntermediateEvent> SysProcessIntermediateEvents { get; set; } = new List<SysProcessIntermediateEvent>();
}
