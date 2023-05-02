using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSqlScriptDependency
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysSqlScriptId { get; set; }

    public Guid? DependOnSqlScriptId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysPackageSqlScript? DependOnSqlScript { get; set; }

    public virtual SysPackageSqlScript? SysSqlScript { get; set; }
}
