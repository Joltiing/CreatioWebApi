using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailTemplateActivity
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? EmailTemplateId { get; set; }

    public Guid? ActivityId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual EmailTemplate? EmailTemplate { get; set; }
}
