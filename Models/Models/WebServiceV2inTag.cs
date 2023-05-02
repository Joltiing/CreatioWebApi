using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WebServiceV2inTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TagId { get; set; }

    public Guid? EntityId { get; set; }

    public virtual ICollection<SysWebServiceV2inTagRight> SysWebServiceV2inTagRights { get; set; } = new List<SysWebServiceV2inTagRight>();

    public virtual WebServiceV2tag? Tag { get; set; }
}
