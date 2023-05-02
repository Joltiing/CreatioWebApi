using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DuplicatesRuleFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public Guid? FolderTypeId { get; set; }

    public byte[]? SearchData { get; set; }

    public int ProcessListeners { get; set; }

    public int OptimizationType { get; set; }

    public virtual ICollection<DuplicatesRuleInFolder> DuplicatesRuleInFolders { get; set; } = new List<DuplicatesRuleInFolder>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<DuplicatesRuleFolder> InverseParent { get; set; } = new List<DuplicatesRuleFolder>();

    public virtual DuplicatesRuleFolder? Parent { get; set; }

    public virtual ICollection<SysDuplicatesRuleFolderLcz> SysDuplicatesRuleFolderLczs { get; set; } = new List<SysDuplicatesRuleFolderLcz>();
}
