using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MkpInstalledAppNewsTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<MkpInstalledAppNewsInTag> MkpInstalledAppNewsInTags { get; set; } = new List<MkpInstalledAppNewsInTag>();

    public virtual ICollection<SysMkpInstalledAppNewsTagRight> SysMkpInstalledAppNewsTagRights { get; set; } = new List<SysMkpInstalledAppNewsTagRight>();

    public virtual TagType? Type { get; set; }
}
