using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminOperation
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public Guid? SysFolderId { get; set; }

    public int ProcessListeners { get; set; }

    public bool UseSystemOperationRestrictions { get; set; }

    public virtual ICollection<SysAdminOperationGrantee> SysAdminOperationGrantees { get; set; } = new List<SysAdminOperationGrantee>();

    public virtual ICollection<SysAdminOperationLcz> SysAdminOperationLczs { get; set; } = new List<SysAdminOperationLcz>();

    public virtual SysAdminOperationFolder? SysFolder { get; set; }
}
