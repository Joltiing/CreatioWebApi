using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DayOfWeek
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public int Number { get; set; }

    public virtual ICollection<DayInCalendar> DayInCalendars { get; set; } = new List<DayInCalendar>();

    public virtual ICollection<MaintenanceWindow> MaintenanceWindows { get; set; } = new List<MaintenanceWindow>();

    public virtual ICollection<SysDayOfWeekLcz> SysDayOfWeekLczs { get; set; } = new List<SysDayOfWeekLcz>();
}
