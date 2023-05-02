using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysDetail
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? DetailSchemaUid { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public virtual ICollection<ProcessInDetail> ProcessInDetails { get; set; } = new List<ProcessInDetail>();

    public virtual ICollection<SspPageDetail> SspPageDetails { get; set; } = new List<SspPageDetail>();

    public virtual ICollection<SysDetailLcz> SysDetailLczs { get; set; } = new List<SysDetailLcz>();
}
