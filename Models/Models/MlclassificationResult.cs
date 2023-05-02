using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MlclassificationResult
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? Key { get; set; }

    public Guid? Value { get; set; }

    public decimal Probability { get; set; }

    public Guid? ModelInstanceUid { get; set; }

    public Guid? ModelId { get; set; }

    public string Significance { get; set; } = null!;

    public virtual Mlmodel? Model { get; set; }
}
