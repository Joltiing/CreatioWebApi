using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessDatum
{
    public Guid? ParentId { get; set; }

    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysSchemaId { get; set; }

    public Guid? OwnerId { get; set; }

    public byte[]? PropertiesData { get; set; }

    public int Status { get; set; }

    public Guid? SchemaElementUid { get; set; }

    public int ProcessListeners { get; set; }

    public int DataVersion { get; set; }

    public virtual ICollection<SysProcessDatum> InverseParent { get; set; } = new List<SysProcessDatum>();

    public virtual SysProcessDatum? Parent { get; set; }

    public virtual ICollection<SysProcessElementDatum> SysProcessElementData { get; set; } = new List<SysProcessElementDatum>();

    public virtual SysSchema? SysSchema { get; set; }
}
