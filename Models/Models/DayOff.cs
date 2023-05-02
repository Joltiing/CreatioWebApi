using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DayOff
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? CalendarId { get; set; }

    public Guid? ContactId { get; set; }

    public DateTime? Date { get; set; }

    public Guid? DayTypeId { get; set; }

    public bool IsRepeated { get; set; }

    public virtual Calendar? Calendar { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual DayType? DayType { get; set; }

    public virtual ICollection<WorkingTimeInterval> WorkingTimeIntervals { get; set; } = new List<WorkingTimeInterval>();
}
