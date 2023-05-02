using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Calendar
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TimeZoneId { get; set; }

    public int Depth { get; set; }

    public bool AroundClock { get; set; }

    public bool WithoutDayOff { get; set; }

    public Guid? UserId { get; set; }

    public virtual ICollection<DayInCalendar> DayInCalendars { get; set; } = new List<DayInCalendar>();

    public virtual ICollection<DayOff> DayOffs { get; set; } = new List<DayOff>();

    public virtual ICollection<Calendar> InverseParent { get; set; } = new List<Calendar>();

    public virtual Calendar? Parent { get; set; }

    public virtual ICollection<SysCalendarLcz> SysCalendarLczs { get; set; } = new List<SysCalendarLcz>();

    public virtual TimeZone? TimeZone { get; set; }

    public virtual SysAdminUnit? User { get; set; }
}
