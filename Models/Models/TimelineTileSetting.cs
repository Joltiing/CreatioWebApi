using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class TimelineTileSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? Data { get; set; }

    public byte[]? Image { get; set; }

    public virtual ICollection<SysTimelineTileSettingLcz> SysTimelineTileSettingLczs { get; set; } = new List<SysTimelineTileSettingLcz>();
}
