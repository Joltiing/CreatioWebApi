using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Currency
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    public int RecalcDirection { get; set; }

    public int Division { get; set; }

    public int ProcessListeners { get; set; }

    public int CurrecySymbolPosition { get; set; }

    public decimal Rate { get; set; }

    public virtual ICollection<CurrencyRate> CurrencyRates { get; set; } = new List<CurrencyRate>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<SysCurrencyLcz> SysCurrencyLczs { get; set; } = new List<SysCurrencyLcz>();
}
