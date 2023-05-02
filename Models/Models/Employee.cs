using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Employee
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ContactId { get; set; }

    public string Name { get; set; } = null!;

    public Guid? OrgStructureUnitId { get; set; }

    public string Notes { get; set; } = null!;

    public Guid? JobId { get; set; }

    public string FullJobTitle { get; set; } = null!;

    public Guid? OwnerId { get; set; }

    public DateTime? CareerStartDate { get; set; }

    public DateTime? CareerDueDate { get; set; }

    public DateTime? ProbationDueDate { get; set; }

    public Guid? ReasonForDismissalId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? ManagerId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual ICollection<EmployeeCareer> EmployeeCareers { get; set; } = new List<EmployeeCareer>();

    public virtual ICollection<EmployeeFile> EmployeeFiles { get; set; } = new List<EmployeeFile>();

    public virtual ICollection<EmployeeInFolder> EmployeeInFolders { get; set; } = new List<EmployeeInFolder>();

    public virtual ICollection<EmployeeInTag> EmployeeInTags { get; set; } = new List<EmployeeInTag>();

    public virtual ICollection<Employee> InverseManager { get; set; } = new List<Employee>();

    public virtual EmployeeJob? Job { get; set; }

    public virtual Employee? Manager { get; set; }

    public virtual OrgStructureUnit? OrgStructureUnit { get; set; }

    public virtual ICollection<OrgStructureUnit> OrgStructureUnits { get; set; } = new List<OrgStructureUnit>();

    public virtual Contact? Owner { get; set; }

    public virtual ReasonForLeaving? ReasonForDismissal { get; set; }

    public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>();

    public virtual ICollection<SysEmployeeLcz> SysEmployeeLczs { get; set; } = new List<SysEmployeeLcz>();
}
