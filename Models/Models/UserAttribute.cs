using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class UserAttribute
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Bpmcolumn { get; set; } = null!;

    public string Adcolumn { get; set; } = null!;
}
