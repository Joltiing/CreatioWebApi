using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysTranslationTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<SysTranslationInTag> SysTranslationInTags { get; set; } = new List<SysTranslationInTag>();

    public virtual ICollection<SysTranslationTagRight> SysTranslationTagRights { get; set; } = new List<SysTranslationTagRight>();

    public virtual TagType? Type { get; set; }
}
