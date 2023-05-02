using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysMsgUserState
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? ImageId { get; set; }

    public bool IsDisplayOnly { get; set; }

    public Guid? IconId { get; set; }

    public virtual SysMsgUserStateIcon? Icon { get; set; }

    public virtual SysImage? Image { get; set; }

    public virtual ICollection<SysMsgUserStateInLib> SysMsgUserStateInLibs { get; set; } = new List<SysMsgUserStateInLib>();

    public virtual ICollection<SysMsgUserStateLcz> SysMsgUserStateLczs { get; set; } = new List<SysMsgUserStateLcz>();

    public virtual ICollection<SysMsgUserStateReason> SysMsgUserStateReasons { get; set; } = new List<SysMsgUserStateReason>();
}
