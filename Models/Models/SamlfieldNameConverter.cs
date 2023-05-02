using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SamlfieldNameConverter
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string SamlfieldName { get; set; } = null!;

    public string ContactFieldName { get; set; } = null!;

    public string ColumnDefaultValue { get; set; } = null!;
}
