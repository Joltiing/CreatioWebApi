using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleAnalyticsReport
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? SysModuleId { get; set; }

    public bool AutoPreview { get; set; }

    public string HelpContextId { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? SysSchemaUid { get; set; }

    public Guid? SysOptionsPageSchemaUid { get; set; }

    public string ModuleSchemaName { get; set; } = null!;

    public Guid? LogoId { get; set; }

    public Guid? TypeId { get; set; }

    public virtual SysImage? Logo { get; set; }

    public virtual SysModule? SysModule { get; set; }

    public virtual ICollection<SysModuleAnalyticsReportLczOld> SysModuleAnalyticsReportLczOlds { get; set; } = new List<SysModuleAnalyticsReportLczOld>();

    public virtual ICollection<SysModuleAnalyticsReportLcz> SysModuleAnalyticsReportLczs { get; set; } = new List<SysModuleAnalyticsReportLcz>();

    public virtual SysModuleReportType? Type { get; set; }
}
