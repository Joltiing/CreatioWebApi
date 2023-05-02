using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Period
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public Guid? PeriodTypeId { get; set; }

    public Guid? YearId { get; set; }

    public Guid? QuarterId { get; set; }

    public Guid? ParentId { get; set; }

    public virtual ICollection<Period> InverseParent { get; set; } = new List<Period>();

    public virtual ICollection<Period> InverseQuarter { get; set; } = new List<Period>();

    public virtual ICollection<Period> InverseYear { get; set; } = new List<Period>();

    public virtual Period? Parent { get; set; }

    public virtual PeriodType? PeriodType { get; set; }

    public virtual Period? Quarter { get; set; }

    public virtual ICollection<SysPeriodLcz> SysPeriodLczs { get; set; } = new List<SysPeriodLcz>();

    public virtual Period? Year { get; set; }
}
