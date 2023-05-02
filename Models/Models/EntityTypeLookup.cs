using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EntityTypeLookup
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string EntityName { get; set; } = null!;

    public string MenuItemCaption { get; set; } = null!;

    public string SysSettingImage { get; set; } = null!;

    public int Position { get; set; }

    public virtual ICollection<SysEntityTypeLookupLcz> SysEntityTypeLookupLczs { get; set; } = new List<SysEntityTypeLookupLcz>();
}
