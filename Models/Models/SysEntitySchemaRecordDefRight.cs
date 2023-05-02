using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEntitySchemaRecordDefRight
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? AuthorSysAdminUnitId { get; set; }

    public Guid? GranteeSysAdminUnitId { get; set; }

    public int Operation { get; set; }

    public int RightLevel { get; set; }

    public int Position { get; set; }

    public Guid? SubjectSchemaUid { get; set; }
}
