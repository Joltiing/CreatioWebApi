using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExcelImport
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<ExcelImportLog> ExcelImportLogs { get; set; } = new List<ExcelImportLog>();
}
