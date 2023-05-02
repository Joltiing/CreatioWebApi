using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysEntitySchemaColumnRight
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SubjectSchemaUid { get; set; }

    public Guid? SubjectColumnUid { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public Guid RightLevelId { get; set; }

    public int Position { get; set; }

    public int ProcessListeners { get; set; }
}
