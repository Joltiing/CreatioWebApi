using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class CurrencyRate
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public Guid? CurrencyId { get; set; }

    public decimal Rate { get; set; }

    public int ProcessListeners { get; set; }

    public string RateMantissa { get; set; } = null!;

    public virtual Currency? Currency { get; set; }
}
