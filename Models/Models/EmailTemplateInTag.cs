using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailTemplateInTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TagId { get; set; }

    public Guid? EntityId { get; set; }

    public virtual EmailTemplate? Entity { get; set; }

    public virtual ICollection<SysEmailTemplateInTagRight> SysEmailTemplateInTagRights { get; set; } = new List<SysEmailTemplateInTagRight>();

    public virtual EmailTemplateTag? Tag { get; set; }
}
