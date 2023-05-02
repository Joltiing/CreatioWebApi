using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class PeriodicitySetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public bool IsDaily { get; set; }

    public int DailyPeriod { get; set; }

    public bool IsWeekly { get; set; }

    public int DayOfWeek { get; set; }

    public bool IsMonthly { get; set; }

    public bool IsMonthlyCustom { get; set; }

    public int DayOfMonth { get; set; }

    public bool IsMonthlyLastDay { get; set; }

    public bool IsOnce { get; set; }

    public TimeSpan? OnceAt { get; set; }

    public bool IsCustom { get; set; }

    public int CustomPeriod { get; set; }

    public int CustomPeriodType { get; set; }

    public TimeSpan? CustomFrom { get; set; }

    public TimeSpan? CustomTill { get; set; }

    public DateTime? SchedulerStart { get; set; }

    public DateTime? SchedulerFinish { get; set; }

    public bool IsSchedulerEndless { get; set; }
}
