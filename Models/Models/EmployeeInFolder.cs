using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmployeeInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual EmployeeFolder? Folder { get; set; }
}
