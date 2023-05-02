using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAppTemplate
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public Guid? ImageId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysImage? Image { get; set; }

    public virtual ICollection<SysAppTemplateLcz> SysAppTemplateLczs { get; set; } = new List<SysAppTemplateLcz>();
}
