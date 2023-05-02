using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LandingObjectDefault
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? LandingId { get; set; }

    public string DisplayValue { get; set; } = null!;

    public Guid? ColumnUid { get; set; }

    public string ColumnCaption { get; set; } = null!;

    public Guid? GuidValue { get; set; }

    public string TextValue { get; set; } = null!;

    public int IntegerValue { get; set; }

    public decimal FloatValue { get; set; }

    public bool BooleanValue { get; set; }

    public DateTime? DateTimeValue { get; set; }

    public virtual GeneratedWebForm? Landing { get; set; }
}
