using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleGridEditPage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? TypeColumnValue { get; set; }

    public Guid? SysModuleGridPageId { get; set; }

    public Guid? SysEditPageSchemaId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysModuleGridPageUid { get; set; }

    public Guid? SysEditPageSchemaUid { get; set; }

    public virtual SysSchema? SysEditPageSchema { get; set; }

    public virtual SysSchema? SysModuleGridPage { get; set; }
}
