using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountEnrichedDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public DateTime? SearchDate { get; set; }

    public string CategoryTag { get; set; } = null!;

    public string Value { get; set; } = null!;

    public Guid? AccountId { get; set; }

    public virtual Account? Account { get; set; }
}
