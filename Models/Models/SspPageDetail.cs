using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SspPageDetail
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? CardSchemaUid { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public Guid? SysDetailId { get; set; }

    public virtual SysDetail? SysDetail { get; set; }
}
