using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public Guid? UnitId { get; set; }

    public Guid? CurrencyId { get; set; }

    public decimal Price { get; set; }

    public Guid? TaxId { get; set; }

    public string Url { get; set; } = null!;

    public Guid? TypeId { get; set; }

    public bool Active { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? OwnerId { get; set; }

    public string Description { get; set; } = null!;

    public Guid? ProductSourceId { get; set; }

    public string Notes { get; set; } = null!;

    public virtual ICollection<ContactsProductInterest> ContactsProductInterests { get; set; } = new List<ContactsProductInterest>();

    public virtual Currency? Currency { get; set; }

    public virtual Contact? Owner { get; set; }

    public virtual ICollection<ProductEntry> ProductEntryCrossSalesOferrings { get; set; } = new List<ProductEntry>();

    public virtual ICollection<ProductEntry> ProductEntryProducts { get; set; } = new List<ProductEntry>();

    public virtual ICollection<ProductFile> ProductFiles { get; set; } = new List<ProductFile>();

    public virtual ICollection<ProductInFolder> ProductInFolders { get; set; } = new List<ProductInFolder>();

    public virtual ICollection<ProductInTag> ProductInTags { get; set; } = new List<ProductInTag>();

    public virtual ProductSource? ProductSource { get; set; }

    public virtual ICollection<SysProductLcz> SysProductLczs { get; set; } = new List<SysProductLcz>();

    public virtual ICollection<SysProductRight> SysProductRights { get; set; } = new List<SysProductRight>();

    public virtual Tax? Tax { get; set; }

    public virtual ProductType? Type { get; set; }

    public virtual Unit? Unit { get; set; }
}
