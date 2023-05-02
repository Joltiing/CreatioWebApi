using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AttributeReferenceSchema
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? AttributeId { get; set; }

    public Guid? ReferenceSchemaId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Attribute? Attribute { get; set; }

    public virtual SysSchema? ReferenceSchema { get; set; }
}
