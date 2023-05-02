using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DayInCalendar
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? DayOfWeekId { get; set; }

    public Guid? DayTypeId { get; set; }

    public DateTime? Date { get; set; }

    public Guid? CalendarId { get; set; }

    public virtual Calendar? Calendar { get; set; }

    public virtual DayOfWeek? DayOfWeek { get; set; }

    public virtual DayType? DayType { get; set; }

    public virtual ICollection<WorkingTimeInterval> WorkingTimeIntervals { get; set; } = new List<WorkingTimeInterval>();
}
