using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmployeeJob
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<EmployeeCareer> EmployeeCareers { get; set; } = new List<EmployeeCareer>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<SysEmployeeJobLcz> SysEmployeeJobLczs { get; set; } = new List<SysEmployeeJobLcz>();
}
