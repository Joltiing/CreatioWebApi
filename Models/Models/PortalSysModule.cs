using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class PortalSysModule
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

    public virtual SysModuleEntity? SysModuleEntity { get; set; }

    public virtual SysModuleVisa? SysModuleVisa { get; set; }

    public virtual ICollection<SysPortalSysModuleLcz> SysPortalSysModuleLczs { get; set; } = new List<SysPortalSysModuleLcz>();
}
