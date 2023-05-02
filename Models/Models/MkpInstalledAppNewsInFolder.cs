﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MkpInstalledAppNewsInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? MkpInstalledAppNewsId { get; set; }

    public virtual MkpInstalledAppNewsFolder? Folder { get; set; }

    public virtual MkpInstalledAppNews? MkpInstalledAppNews { get; set; }

    public virtual ICollection<SysMkpInstAppNewsInFolderRight> SysMkpInstAppNewsInFolderRights { get; set; } = new List<SysMkpInstAppNewsInFolderRight>();
}
