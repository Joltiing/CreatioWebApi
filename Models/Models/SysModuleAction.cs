using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleAction
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? SysModuleId { get; set; }

    public string HelpContextId { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public int Position { get; set; }

    public Guid? TypeId { get; set; }

    public byte[]? Image { get; set; }

    public Guid? SysProcessSchemaUid { get; set; }

    public virtual SysModule? SysModule { get; set; }

    public virtual ICollection<SysModuleActionLczOld> SysModuleActionLczOlds { get; set; } = new List<SysModuleActionLczOld>();

    public virtual ICollection<SysModuleActionLcz> SysModuleActionLczs { get; set; } = new List<SysModuleActionLcz>();

    public virtual SysModuleActionType? Type { get; set; }
}
