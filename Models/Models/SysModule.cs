using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModule
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? SysModuleEntityId { get; set; }

    public byte[]? Image16 { get; set; }

    public byte[]? Image20 { get; set; }

    public Guid? FolderModeId { get; set; }

    public bool GlobalSearchAvailable { get; set; }

    public bool HasAnalytics { get; set; }

    public bool HasActions { get; set; }

    public bool HasRecent { get; set; }

    public string Code { get; set; } = null!;

    public string HelpContextId { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string ModuleHeader { get; set; } = null!;

    public string Attribute { get; set; } = null!;

    public Guid? SysPageSchemaUid { get; set; }

    public Guid? CardSchemaUid { get; set; }

    public Guid? SectionModuleSchemaUid { get; set; }

    public Guid? SectionSchemaUid { get; set; }

    public Guid? CardModuleUid { get; set; }

    public Guid? TypeColumnValue { get; set; }

    public Guid? Image32Id { get; set; }

    public Guid? LogoId { get; set; }

    public Guid? SysModuleVisaId { get; set; }

    public bool IsSystem { get; set; }

    public int Type { get; set; }

    public virtual SysModuleFolderMode? FolderMode { get; set; }

    public virtual SysImage? Image32 { get; set; }

    public virtual SysImage? Logo { get; set; }

    public virtual ICollection<MessageNotifierBySection> MessageNotifierBySections { get; set; } = new List<MessageNotifierBySection>();

    public virtual ICollection<MessagePublisherBySection> MessagePublisherBySections { get; set; } = new List<MessagePublisherBySection>();

    public virtual ICollection<ProcessInModule> ProcessInModules { get; set; } = new List<ProcessInModule>();

    public virtual ICollection<SysAdminUnit> SysAdminUnits { get; set; } = new List<SysAdminUnit>();

    public virtual ICollection<SysDashboard> SysDashboards { get; set; } = new List<SysDashboard>();

    public virtual ICollection<SysModuleAction> SysModuleActions { get; set; } = new List<SysModuleAction>();

    public virtual ICollection<SysModuleAnalyticsReport> SysModuleAnalyticsReports { get; set; } = new List<SysModuleAnalyticsReport>();

    public virtual ICollection<SysModuleDetail> SysModuleDetails { get; set; } = new List<SysModuleDetail>();

    public virtual SysModuleEntity? SysModuleEntity { get; set; }

    public virtual ICollection<SysModuleInSysModuleFolder> SysModuleInSysModuleFolders { get; set; } = new List<SysModuleInSysModuleFolder>();

    public virtual ICollection<SysModuleInWorkplace> SysModuleInWorkplaces { get; set; } = new List<SysModuleInWorkplace>();

    public virtual ICollection<SysModuleLczOld> SysModuleLczOlds { get; set; } = new List<SysModuleLczOld>();

    public virtual ICollection<SysModuleLcz> SysModuleLczs { get; set; } = new List<SysModuleLcz>();

    public virtual ICollection<SysModulePrimaryGrid> SysModulePrimaryGrids { get; set; } = new List<SysModulePrimaryGrid>();

    public virtual ICollection<SysModuleReport> SysModuleReports { get; set; } = new List<SysModuleReport>();

    public virtual SysModuleVisa? SysModuleVisa { get; set; }

    public virtual ICollection<SysWidgetDashboard> SysWidgetDashboards { get; set; } = new List<SysWidgetDashboard>();
}
