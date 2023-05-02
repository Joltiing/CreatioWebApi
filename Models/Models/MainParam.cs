using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MainParam
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SubjectSchemaUid { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CommandParam> CommandParams { get; set; } = new List<CommandParam>();

    public virtual ICollection<Macro> Macros { get; set; } = new List<Macro>();

    public virtual ICollection<MainParamLczOld> MainParamLczOlds { get; set; } = new List<MainParamLczOld>();

    public virtual ICollection<SysMainParamLcz> SysMainParamLczs { get; set; } = new List<SysMainParamLcz>();
}
