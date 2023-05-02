using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LeadMedium
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<FormSubmit> FormSubmits { get; set; } = new List<FormSubmit>();

    public virtual ICollection<LeadMediumCode> LeadMediumCodes { get; set; } = new List<LeadMediumCode>();

    public virtual ICollection<LeadSource> LeadSources { get; set; } = new List<LeadSource>();

    public virtual ICollection<SysLeadMediumLcz> SysLeadMediumLczs { get; set; } = new List<SysLeadMediumLcz>();

    public virtual ICollection<Touch> Touches { get; set; } = new List<Touch>();
}
