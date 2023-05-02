using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DuplicatesRule
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public Guid? ObjectId { get; set; }

    public string RuleBody { get; set; } = null!;

    public string ProcedureName { get; set; } = null!;

    public bool UseAtSave { get; set; }

    public Guid? SearchObjectId { get; set; }

    public virtual ICollection<DuplicatesRuleInFolder> DuplicatesRuleInFolders { get; set; } = new List<DuplicatesRuleInFolder>();

    public virtual ICollection<DuplicatesRuleInTag> DuplicatesRuleInTags { get; set; } = new List<DuplicatesRuleInTag>();

    public virtual ICollection<SysDuplicatesRuleLcz> SysDuplicatesRuleLczs { get; set; } = new List<SysDuplicatesRuleLcz>();
}
