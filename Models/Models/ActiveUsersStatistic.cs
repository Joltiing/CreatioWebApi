using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActiveUsersStatistic
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public DateTime? DateValue { get; set; }

    public int SessionCount { get; set; }

    public int SysUserCount { get; set; }

    public int PortalUserCount { get; set; }
}
