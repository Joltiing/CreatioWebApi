using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysInstalledPackageDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? SysSchemaId { get; set; }

    public Guid? RecordId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysPackage? SysPackage { get; set; }

    public virtual SysSchema? SysSchema { get; set; }
}
