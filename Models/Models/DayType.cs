using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DayType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string Color { get; set; } = null!;

    public bool IsWeekend { get; set; }

    public bool NonWorking { get; set; }

    public virtual ICollection<DayInCalendar> DayInCalendars { get; set; } = new List<DayInCalendar>();

    public virtual ICollection<DayOff> DayOffs { get; set; } = new List<DayOff>();

    public virtual ICollection<SysDayTypeLcz> SysDayTypeLczs { get; set; } = new List<SysDayTypeLcz>();
}
