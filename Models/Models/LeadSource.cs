using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LeadSource
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? LeadMediumId { get; set; }

    public virtual ICollection<FormSubmit> FormSubmits { get; set; } = new List<FormSubmit>();

    public virtual LeadMedium? LeadMedium { get; set; }

    public virtual ICollection<LeadSourceCode> LeadSourceCodes { get; set; } = new List<LeadSourceCode>();

    public virtual ICollection<LeadSourceUrl> LeadSourceUrls { get; set; } = new List<LeadSourceUrl>();

    public virtual ICollection<SysLeadSourceLcz> SysLeadSourceLczs { get; set; } = new List<SysLeadSourceLcz>();

    public virtual ICollection<Touch> Touches { get; set; } = new List<Touch>();
}
