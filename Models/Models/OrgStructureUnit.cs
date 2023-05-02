using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OrgStructureUnit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public Guid? HeadId { get; set; }

    public Guid? ParentId { get; set; }

    public string FullName { get; set; } = null!;

    public virtual ICollection<EmployeeCareer> EmployeeCareers { get; set; } = new List<EmployeeCareer>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Employee? Head { get; set; }

    public virtual ICollection<OrgStructureUnit> InverseParent { get; set; } = new List<OrgStructureUnit>();

    public virtual OrgStructureUnit? Parent { get; set; }

    public virtual ICollection<SysOrgStructureUnitLcz> SysOrgStructureUnitLczs { get; set; } = new List<SysOrgStructureUnitLcz>();
}
