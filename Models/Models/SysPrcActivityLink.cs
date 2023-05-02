using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcActivityLink
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ActivityColumnId { get; set; }

    public string ActivityColumnName { get; set; } = null!;

    public int Position { get; set; }

    public bool IsActive { get; set; }
}
