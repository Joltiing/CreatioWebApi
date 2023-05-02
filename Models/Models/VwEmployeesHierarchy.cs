using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwEmployeesHierarchy
{
    public Guid? EmployeeId { get; set; }

    public Guid ManagerUserId { get; set; }
}
