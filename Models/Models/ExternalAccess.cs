using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExternalAccess
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string AccessReason { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public Guid? GrantorId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDataIsolationEnabled { get; set; }

    public bool IsSystemOperationsRestricted { get; set; }

    public Guid? ExternalAccessClientId { get; set; }

    public virtual ExternalAccessClient? ExternalAccessClient { get; set; }

    public virtual ICollection<ExternalAccessFile> ExternalAccessFiles { get; set; } = new List<ExternalAccessFile>();

    public virtual ICollection<ExternalAccessInFolder> ExternalAccessInFolders { get; set; } = new List<ExternalAccessInFolder>();

    public virtual ICollection<ExternalAccessInTag> ExternalAccessInTags { get; set; } = new List<ExternalAccessInTag>();

    public virtual Contact? Grantor { get; set; }

    public virtual ICollection<SysIsolatedRecord> SysIsolatedRecords { get; set; } = new List<SysIsolatedRecord>();

    public virtual ICollection<SysUserSession> SysUserSessions { get; set; } = new List<SysUserSession>();
}
