using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysLookup
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? SysFolderId { get; set; }

    public Guid? SysEntitySchemaUid { get; set; }

    public Guid? SysGridPageSchemaUid { get; set; }

    public Guid? SysEditPageSchemaUid { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public int ProcessListeners { get; set; }

    public bool IsSystem { get; set; }

    public bool IsSimple { get; set; }
}
