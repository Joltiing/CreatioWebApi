using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContextElement
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ClientUnitSchemaUid { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsDefault { get; set; }

    public virtual ICollection<SysContextElementLcz> SysContextElementLczs { get; set; } = new List<SysContextElementLcz>();
}
