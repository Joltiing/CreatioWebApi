using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Attribute
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? OwnerSchemaId { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? ValueType { get; set; }

    public Guid? ReferenceSchemaId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<AttributeReferenceSchema> AttributeReferenceSchemas { get; set; } = new List<AttributeReferenceSchema>();

    public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new List<AttributeValue>();

    public virtual SysSchema? OwnerSchema { get; set; }

    public virtual SysSchema? ReferenceSchema { get; set; }

    public virtual ICollection<SysAttributeLcz> SysAttributeLczs { get; set; } = new List<SysAttributeLcz>();
}
