using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ProcessInModule
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysModuleId { get; set; }

    public Guid? SysSchemaUid { get; set; }

    public int Position { get; set; }

    public Guid? ParameterUid { get; set; }

    public virtual SysModule? SysModule { get; set; }
}
