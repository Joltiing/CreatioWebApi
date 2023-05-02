using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysLookupInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public Guid? VwSysLookupId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysLookupFolder? Folder { get; set; }

    public virtual SysLookup? VwSysLookup { get; set; }
}
