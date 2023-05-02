using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysModuleSchemaEdit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string PageCaption { get; set; } = null!;

    public Guid? TypeColumnValue { get; set; }

    public Guid? SysModuleEntityId { get; set; }

    public Guid? MiniPageSchemaUid { get; set; }

    public string MiniPageModes { get; set; } = null!;

    public string EditPageCaption { get; set; } = null!;

    public string EditPageName { get; set; } = null!;
}
