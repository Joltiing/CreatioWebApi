using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class PortalSchemaAccessList
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string AccessEntitySchemaName { get; set; } = null!;

    public Guid? SchemaUid { get; set; }

    public virtual ICollection<PortalColumnAccessList> PortalColumnAccessLists { get; set; } = new List<PortalColumnAccessList>();
}
