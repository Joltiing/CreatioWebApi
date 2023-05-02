using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class TimeZone
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Offset { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string CodeAmerican { get; set; } = null!;

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();

    public virtual ICollection<FormSubmit> FormSubmits { get; set; } = new List<FormSubmit>();

    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();

    public virtual ICollection<SysTimeZoneLcz> SysTimeZoneLczs { get; set; } = new List<SysTimeZoneLcz>();
}
