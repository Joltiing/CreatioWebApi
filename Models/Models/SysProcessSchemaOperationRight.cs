using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessSchemaOperationRight
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public int Position { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public Guid? RootProcessSchemaUid { get; set; }

    public bool CanExecute { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
