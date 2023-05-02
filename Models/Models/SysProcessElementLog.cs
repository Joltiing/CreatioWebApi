﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessElementLog
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SchemaElementUid { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? CompleteDate { get; set; }

    public Guid? SysProcessId { get; set; }

    public Guid? StatusId { get; set; }

    public string Type { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public Guid? OwnerId { get; set; }

    public string ErrorDescription { get; set; } = null!;

    public decimal DurationInMinutes { get; set; }

    public decimal DurationInHours { get; set; }

    public decimal DurationInDays { get; set; }

    public string NodeId { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public decimal DurationInMilliseconds { get; set; }

    public string ClientIp { get; set; } = null!;

    public virtual SysProcessStatus? Status { get; set; }

    public virtual ICollection<SysPrcElMilog> SysPrcElMilogs { get; set; } = new List<SysPrcElMilog>();

    public virtual SysProcessLog? SysProcess { get; set; }
}
