using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AdditionalParam
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SubjectColumnUid { get; set; }

    public string ColumnCaption { get; set; } = null!;

    public Guid? SubjectSchemaUid { get; set; }

    public virtual ICollection<CommandParam> CommandParams { get; set; } = new List<CommandParam>();

    public virtual ICollection<Macro> Macros { get; set; } = new List<Macro>();

    public virtual ICollection<SysAdditionalParamLcz> SysAdditionalParamLczs { get; set; } = new List<SysAdditionalParamLcz>();
}
