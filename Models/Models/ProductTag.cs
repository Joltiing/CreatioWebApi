using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ProductTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ProductInTag> ProductInTags { get; set; } = new List<ProductInTag>();

    public virtual ICollection<SysProductTagRight> SysProductTagRights { get; set; } = new List<SysProductTagRight>();

    public virtual TagType? Type { get; set; }
}
