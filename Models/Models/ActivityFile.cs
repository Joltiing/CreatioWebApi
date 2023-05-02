using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityFile
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public Guid? LockedById { get; set; }

    public DateTime? LockedOn { get; set; }

    public byte[]? Data { get; set; }

    public Guid? TypeId { get; set; }

    public int Version { get; set; }

    public int Size { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ActivityId { get; set; }

    public bool CreatedByInvCrm { get; set; }

    public bool Uploaded { get; set; }

    public string ErrorOnUpload { get; set; } = null!;

    public string ExternalStorageProperties { get; set; } = null!;

    public bool Inline { get; set; }

    public Guid? SysFileStorageId { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual Contact? LockedBy { get; set; }

    public virtual FileType? Type { get; set; }
}
