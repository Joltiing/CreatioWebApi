using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WebServiceV2tag
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public virtual ICollection<SysWebServiceV2tagRight> SysWebServiceV2tagRights { get; set; } = new List<SysWebServiceV2tagRight>();

    public virtual TagType? Type { get; set; }

    public virtual ICollection<WebServiceV2inTag> WebServiceV2inTags { get; set; } = new List<WebServiceV2inTag>();
}
