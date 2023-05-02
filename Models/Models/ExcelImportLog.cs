using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExcelImportLog
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string MessageText { get; set; } = null!;

    public Guid? ExcelImportId { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string StackTrace { get; set; } = null!;

    public virtual ExcelImport? ExcelImport { get; set; }
}
