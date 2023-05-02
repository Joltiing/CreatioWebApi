using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WebFormProcessHandler
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string EntityName { get; set; } = null!;

    public string FullClassName { get; set; } = null!;

    public bool IsActive { get; set; }
}
