using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEditPage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPageSchemaId { get; set; }

    public Guid? SysGridPageId { get; set; }

    public Guid? SysEntitySchemaId { get; set; }

    public Guid? TypeColumnValue { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysSchema? SysEntitySchema { get; set; }

    public virtual SysGridPage? SysGridPage { get; set; }

    public virtual SysSchema? SysPageSchema { get; set; }
}
