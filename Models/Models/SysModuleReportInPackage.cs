using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleReportInPackage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysModuleReportPackageId { get; set; }

    public Guid? SysModuleReportId { get; set; }

    public virtual SysModuleReport? SysModuleReport { get; set; }

    public virtual SysModuleReportPackage? SysModuleReportPackage { get; set; }
}
