using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DuplicatesRuleTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DuplicatesRuleInTag> DuplicatesRuleInTags { get; set; } = new List<DuplicatesRuleInTag>();

    public virtual ICollection<SysDuplicatesRuleTagRight> SysDuplicatesRuleTagRights { get; set; } = new List<SysDuplicatesRuleTagRight>();

    public virtual TagType? Type { get; set; }
}
