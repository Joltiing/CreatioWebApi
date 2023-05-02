using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LandingType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? SchemaUidId { get; set; }

    public virtual ICollection<GeneratedWebForm> GeneratedWebForms { get; set; } = new List<GeneratedWebForm>();

    public virtual ICollection<SysLandingTypeLcz> SysLandingTypeLczs { get; set; } = new List<SysLandingTypeLcz>();
}
