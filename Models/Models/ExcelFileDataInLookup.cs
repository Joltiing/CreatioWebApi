using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExcelFileDataInLookup
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string FileValue { get; set; } = null!;

    public string LookupName { get; set; } = null!;

    public string LookupValue { get; set; } = null!;

    public int ProcessListeners { get; set; }
}
