using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysGridPage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPageSchemaId { get; set; }

    public Guid? SysEntitySchemaId { get; set; }

    public Guid? TypeColumnUid { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysEditPage> SysEditPages { get; set; } = new List<SysEditPage>();

    public virtual SysSchema? SysEntitySchema { get; set; }

    public virtual ICollection<SysGridPageView> SysGridPageViews { get; set; } = new List<SysGridPageView>();

    public virtual SysSchema? SysPageSchema { get; set; }
}
