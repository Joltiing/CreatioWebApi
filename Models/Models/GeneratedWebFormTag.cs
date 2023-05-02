using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class GeneratedWebFormTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GeneratedWebFormInTag> GeneratedWebFormInTags { get; set; } = new List<GeneratedWebFormInTag>();

    public virtual ICollection<SysGeneratedWebFormTagRight> SysGeneratedWebFormTagRights { get; set; } = new List<SysGeneratedWebFormTagRight>();

    public virtual TagType? Type { get; set; }
}
