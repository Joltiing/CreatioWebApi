using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ContactInTag> ContactInTags { get; set; } = new List<ContactInTag>();

    public virtual ICollection<SysContactTagRight> SysContactTagRights { get; set; } = new List<SysContactTagRight>();

    public virtual TagType? Type { get; set; }
}
