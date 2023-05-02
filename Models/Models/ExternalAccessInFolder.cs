using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExternalAccessInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ExternalAccessId { get; set; }

    public virtual ExternalAccess? ExternalAccess { get; set; }

    public virtual ExternalAccessFolder? Folder { get; set; }

    public virtual ICollection<SysExternalAccessInFolderRight> SysExternalAccessInFolderRights { get; set; } = new List<SysExternalAccessInFolderRight>();
}
