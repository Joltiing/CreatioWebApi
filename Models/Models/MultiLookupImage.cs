using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MultiLookupImage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Code { get; set; } = null!;

    public Guid? LookupImageId { get; set; }

    public virtual SysImage? LookupImage { get; set; }
}
