using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MlmodelTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<MlmodelInTag> MlmodelInTags { get; set; } = new List<MlmodelInTag>();

    public virtual ICollection<SysMlmodelTagRight> SysMlmodelTagRights { get; set; } = new List<SysMlmodelTagRight>();

    public virtual TagType? Type { get; set; }
}
