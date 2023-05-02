using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmployeeTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EmployeeInTag> EmployeeInTags { get; set; } = new List<EmployeeInTag>();

    public virtual ICollection<SysEmployeeTagRight> SysEmployeeTagRights { get; set; } = new List<SysEmployeeTagRight>();

    public virtual TagType? Type { get; set; }
}
