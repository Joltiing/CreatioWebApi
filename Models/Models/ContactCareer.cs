using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactCareer
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? JobId { get; set; }

    public string JobTitle { get; set; } = null!;

    public bool Primary { get; set; }

    public bool Current { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public Guid? JobChangeReasonId { get; set; }

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? DecisionRoleId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual ContactDecisionRole? DecisionRole { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Job? Job { get; set; }

    public virtual JobChangeReason? JobChangeReason { get; set; }
}
