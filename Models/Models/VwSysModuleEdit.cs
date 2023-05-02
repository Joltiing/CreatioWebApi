using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysModuleEdit
{
    public Guid Id { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? SysModuleEntityId { get; set; }

    public Guid? SysPageSchemaUid { get; set; }

    public Guid? TypeColumnValue { get; set; }

    public bool UseModuleDetails { get; set; }

    public int Position { get; set; }

    public string Caption { get; set; } = null!;

    public string HelpContextId { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? CardSchemaUid { get; set; }

    public string ActionKindCaption { get; set; } = null!;

    public string ActionKindName { get; set; } = null!;

    public string PageCaption { get; set; } = null!;

    public Guid? SysWorkspaceId { get; set; }
}
