using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysProcessElementLog
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

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

    public decimal? DurationInSeconds { get; set; }

    public decimal DurationInMilliseconds { get; set; }

    public bool? Archived { get; set; }

    public bool? HasTraceData { get; set; }

    public string NodeId { get; set; } = null!;
}
