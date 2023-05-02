using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MlmodelColumnType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<MlmodelColumn> MlmodelColumns { get; set; } = new List<MlmodelColumn>();

    public virtual ICollection<SysMlmodelColumnTypeLcz> SysMlmodelColumnTypeLczs { get; set; } = new List<SysMlmodelColumnTypeLcz>();
}
