using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEntitySchemaReference
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysSchemaId { get; set; }

    public Guid? ColumnUid { get; set; }

    public string ColumnName { get; set; } = null!;

    public string ColumnCaption { get; set; } = null!;

    public Guid? ReferenceSchemaId { get; set; }

    public int UsageType { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysSchema? ReferenceSchema { get; set; }

    public virtual ICollection<SysEntitySchemaReferenceLcz> SysEntitySchemaReferenceLczs { get; set; } = new List<SysEntitySchemaReferenceLcz>();

    public virtual SysSchema? SysSchema { get; set; }
}
