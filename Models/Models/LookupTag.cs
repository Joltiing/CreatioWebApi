using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LookupTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<LookupInTag> LookupInTags { get; set; } = new List<LookupInTag>();

    public virtual ICollection<SysLookupTagRight> SysLookupTagRights { get; set; } = new List<SysLookupTagRight>();

    public virtual TagType? Type { get; set; }
}
