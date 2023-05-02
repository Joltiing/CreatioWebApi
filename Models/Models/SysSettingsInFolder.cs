using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSettingsInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysSettingsId { get; set; }

    public virtual SysSettingsFolder? Folder { get; set; }

    public virtual SysSetting? SysSettings { get; set; }
}
