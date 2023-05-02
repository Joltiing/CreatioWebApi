using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EsnnotificationType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string Action { get; set; } = null!;

    public Guid? IconId { get; set; }

    public virtual ICollection<Esnnotification> Esnnotifications { get; set; } = new List<Esnnotification>();

    public virtual SysImage? Icon { get; set; }

    public virtual ICollection<SysEsnnotificationTypeLcz> SysEsnnotificationTypeLczs { get; set; } = new List<SysEsnnotificationTypeLcz>();
}
