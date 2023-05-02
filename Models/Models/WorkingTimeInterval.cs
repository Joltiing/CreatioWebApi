using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WorkingTimeInterval
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? DayInCalendarId { get; set; }

    public TimeSpan? From { get; set; }

    public TimeSpan? To { get; set; }

    public int Index { get; set; }

    public Guid? DayOffId { get; set; }

    public virtual DayInCalendar? DayInCalendar { get; set; }

    public virtual DayOff? DayOff { get; set; }
}
