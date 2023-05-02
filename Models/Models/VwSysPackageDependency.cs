using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysPackageDependency
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? PackageId { get; set; }

    public Guid? DependOnPackageId { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
