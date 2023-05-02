using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContentUserBlock
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Config { get; set; } = null!;

    public Guid? ImageId { get; set; }

    public string Description { get; set; } = null!;

    public virtual SysImage? Image { get; set; }

    public virtual ICollection<SysContentUserBlockLcz> SysContentUserBlockLczs { get; set; } = new List<SysContentUserBlockLcz>();
}
