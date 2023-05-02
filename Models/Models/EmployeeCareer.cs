using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmployeeCareer
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? OrgStructureUnitId { get; set; }

    public Guid? EmployeeJobId { get; set; }

    public string FullJobTitle { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public bool IsCurrent { get; set; }

    public DateTime? ProbationDueDate { get; set; }

    public Guid? ReasonForDismissalId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual EmployeeJob? EmployeeJob { get; set; }

    public virtual OrgStructureUnit? OrgStructureUnit { get; set; }

    public virtual ReasonForLeaving? ReasonForDismissal { get; set; }
}
