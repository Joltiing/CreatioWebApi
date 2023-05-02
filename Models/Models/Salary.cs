using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Salary
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? EmployeeId { get; set; }

    public decimal SalaryBaseValue { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public Guid? UnitForCalculationId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual UnitForCalculation? UnitForCalculation { get; set; }
}
