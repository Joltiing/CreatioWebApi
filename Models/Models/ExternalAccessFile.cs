using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExternalAccessFile
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

    public Guid? ExternalAccessId { get; set; }

    public Guid? SysFileStorageId { get; set; }

    public virtual ExternalAccess? ExternalAccess { get; set; }

    public virtual Contact? LockedBy { get; set; }

    public virtual FileType? Type { get; set; }
}
