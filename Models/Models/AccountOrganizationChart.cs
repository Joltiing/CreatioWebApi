using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountOrganizationChart
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? AccountId { get; set; }

    public string CustomDepartmentName { get; set; } = null!;

    public Guid? DepartmentId { get; set; }

    public Guid? ManagerId { get; set; }

    public string Description { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<AccountOrganizationChart> InverseParent { get; set; } = new List<AccountOrganizationChart>();

    public virtual Contact? Manager { get; set; }

    public virtual AccountOrganizationChart? Parent { get; set; }
}
