﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MkpInstalledAppNewsFile
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

    public Guid? MkpInstalledAppNewsId { get; set; }

    public Guid? SysFileStorageId { get; set; }

    public virtual Contact? LockedBy { get; set; }

    public virtual MkpInstalledAppNews? MkpInstalledAppNews { get; set; }

    public virtual FileType? Type { get; set; }
}
