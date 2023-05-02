using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DuplicateStatus
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<AccountDuplicate> AccountDuplicates { get; set; } = new List<AccountDuplicate>();

    public virtual ICollection<ContactDuplicate> ContactDuplicates { get; set; } = new List<ContactDuplicate>();

    public virtual ICollection<SysDuplicateStatusLcz> SysDuplicateStatusLczs { get; set; } = new List<SysDuplicateStatusLcz>();
}
