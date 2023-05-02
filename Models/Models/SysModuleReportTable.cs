using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleReportTable
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string MacrosList { get; set; } = null!;

    public Guid? SysModuleReportId { get; set; }

    public string ReferenceColumn { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public byte[]? Filter { get; set; }

    public Guid? ObjectId { get; set; }

    public string ObjectColumnPath { get; set; } = null!;

    public string ObjectColumnCaption { get; set; } = null!;

    public string ReferenceColumnCaption { get; set; } = null!;

    public bool IsEmptyTableHide { get; set; }

    public string FilterSettings { get; set; } = null!;

    public string MacrosSettings { get; set; } = null!;

    public virtual SysModuleReport? SysModuleReport { get; set; }
}
