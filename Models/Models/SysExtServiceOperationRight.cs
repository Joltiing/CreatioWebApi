using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysExtServiceOperationRight
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public bool CanRead { get; set; }

    public bool CanAppend { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public int Position { get; set; }

    public Guid? SubjectSchemaUid { get; set; }

    public int ProcessListeners { get; set; }
}
