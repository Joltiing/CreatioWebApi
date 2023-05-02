using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLookup
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsSystem { get; set; }

    public bool IsSimple { get; set; }

    public Guid? SysEditPageSchemaUid { get; set; }

    public Guid? SysGridPageSchemaUid { get; set; }

    public Guid? SysEntitySchemaUid { get; set; }

    public Guid? SysFolderId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysLookupFolder? SysFolder { get; set; }

    public virtual ICollection<SysLookupColumn> SysLookupColumns { get; set; } = new List<SysLookupColumn>();

    public virtual ICollection<SysLookupSearchColumn> SysLookupSearchColumns { get; set; } = new List<SysLookupSearchColumn>();

    public virtual ICollection<VwSysLookupInFolder> VwSysLookupInFolders { get; set; } = new List<VwSysLookupInFolder>();
}
