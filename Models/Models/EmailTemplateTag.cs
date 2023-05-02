using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailTemplateTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EmailTemplateInTag> EmailTemplateInTags { get; set; } = new List<EmailTemplateInTag>();

    public virtual ICollection<SysEmailTemplateTagRight> SysEmailTemplateTagRights { get; set; } = new List<SysEmailTemplateTagRight>();

    public virtual TagType? Type { get; set; }
}
