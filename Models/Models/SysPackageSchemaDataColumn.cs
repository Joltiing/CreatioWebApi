using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageSchemaDataColumn
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPackageSchemaDataId { get; set; }

    public Guid? PackageSchemaColumnUid { get; set; }

    public bool IsForceUpdate { get; set; }

    public bool IsKey { get; set; }

    public string ColumnName { get; set; } = null!;

    public Guid? DataValueTypeUid { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysPackageSchemaDatum? SysPackageSchemaData { get; set; }
}
