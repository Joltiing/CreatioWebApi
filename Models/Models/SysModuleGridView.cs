using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleGridView
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? SysModuleGridId { get; set; }

    public string Code { get; set; } = null!;

    public int Position { get; set; }

    public byte[]? SearchData { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysModuleGrid? SysModuleGrid { get; set; }

    public virtual ICollection<SysModuleGridViewLcz> SysModuleGridViewLczs { get; set; } = new List<SysModuleGridViewLcz>();
}
