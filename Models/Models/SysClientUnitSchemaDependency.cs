using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysClientUnitSchemaDependency
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Uid { get; set; }

    public Guid? CreatedInSchemaUid { get; set; }

    public Guid? ModifiedInSchemaUid { get; set; }

    public string Name { get; set; } = null!;

    public Guid? SchemaUid { get; set; }

    public string ManagerName { get; set; } = null!;

    public Guid? SysSchemaId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysSchema? SysSchema { get; set; }
}
