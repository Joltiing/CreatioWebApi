using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleReport
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

    public string MacrosList { get; set; } = null!;

    public Guid? TypeId { get; set; }

    public byte[]? File { get; set; }

    public string FileName { get; set; } = null!;

    public Guid? SysReportSchemaUid { get; set; }

    public Guid? SysOptionsPageSchemaUid { get; set; }

    public bool ShowInSection { get; set; }

    public bool ShowInCard { get; set; }

    public bool ConvertInPdf { get; set; }

    public Guid? TypeColumnValue { get; set; }

    public string MacrosSettings { get; set; } = null!;

    public virtual SysModule? SysModule { get; set; }

    public virtual ICollection<SysModuleReportInPackage> SysModuleReportInPackages { get; set; } = new List<SysModuleReportInPackage>();

    public virtual ICollection<SysModuleReportLczOld> SysModuleReportLczOlds { get; set; } = new List<SysModuleReportLczOld>();

    public virtual ICollection<SysModuleReportLcz> SysModuleReportLczs { get; set; } = new List<SysModuleReportLcz>();

    public virtual ICollection<SysModuleReportTable> SysModuleReportTables { get; set; } = new List<SysModuleReportTable>();

    public virtual SysModuleReportType? Type { get; set; }
}
