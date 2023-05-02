using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysOmniChatActionLcz
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysCultureId { get; set; }

    public string? Caption { get; set; }

    public virtual OmniChatAction? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
