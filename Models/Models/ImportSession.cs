using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ImportSession
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public bool IsCanceled { get; set; }

    public Guid? ProcessId { get; set; }

    public virtual ICollection<SysImportSessionRight> SysImportSessionRights { get; set; } = new List<SysImportSessionRight>();
}
