using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailDefRight
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public int Operation { get; set; }

    public int RightLevel { get; set; }

    public Guid? RecordId { get; set; }

    public int Position { get; set; }

    public virtual MailboxSyncSetting? Record { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
