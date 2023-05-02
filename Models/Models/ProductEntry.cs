using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ProductEntry
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CrossSalesOferringId { get; set; }

    public string Notes { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual Product? CrossSalesOferring { get; set; }

    public virtual Product? Product { get; set; }
}
