using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageDataLcz
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPackageSchemaDataId { get; set; }

    public Guid? SysCultureId { get; set; }

    public byte[]? Data { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysCulture? SysCulture { get; set; }

    public virtual SysPackageSchemaDatum? SysPackageSchemaData { get; set; }
}
