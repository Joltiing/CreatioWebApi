using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AttributeValue
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Record { get; set; }

    public Guid? AttributeId { get; set; }

    public string TextValue { get; set; } = null!;

    public int IntegerValue { get; set; }

    public decimal FloatValue { get; set; }

    public bool BooleanValue { get; set; }

    public DateTime? DateTimeValue { get; set; }

    public Guid? GuidValue { get; set; }

    public byte[]? BinaryValue { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Attribute? Attribute { get; set; }
}
