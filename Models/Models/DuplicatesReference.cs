using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DuplicatesReference
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string ObjectName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;
}
