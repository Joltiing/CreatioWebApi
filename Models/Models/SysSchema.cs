using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSchema
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Uid { get; set; }

    public string Name { get; set; } = null!;

    public Guid? SysPackageId { get; set; }

    public bool IsLocked { get; set; }

    public bool IsChanged { get; set; }

    public string ManagerName { get; set; } = null!;

    public Guid? LockedById { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public byte[]? MetaData { get; set; }

    public DateTime? MetaDataModifiedOn { get; set; }

    public bool ExtendParent { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? ClientContentModifiedOn { get; set; }

    public DateTime? StructureModifiedOn { get; set; }

    public string LastError { get; set; } = null!;

    public byte[]? Descriptor { get; set; }

    public bool DenyExtending { get; set; }

    public string Checksum { get; set; } = null!;

    public bool IsNetStandard { get; set; }

    public int ProcessListeners { get; set; }

    public bool IncludeDependenciesSource { get; set; }

    public virtual ICollection<Attribute> AttributeOwnerSchemas { get; set; } = new List<Attribute>();

    public virtual ICollection<Attribute> AttributeReferenceSchemas { get; set; } = new List<Attribute>();

    public virtual ICollection<AttributeReferenceSchema> AttributeReferenceSchemasNavigation { get; set; } = new List<AttributeReferenceSchema>();

    public virtual ICollection<SysSchema> InverseParent { get; set; } = new List<SysSchema>();

    public virtual SysAdminUnit? LockedBy { get; set; }

    public virtual SysSchema? Parent { get; set; }

    public virtual ICollection<Playbook> Playbooks { get; set; } = new List<Playbook>();

    public virtual ICollection<SysClientUnitSchemaDependency> SysClientUnitSchemaDependencies { get; set; } = new List<SysClientUnitSchemaDependency>();

    public virtual ICollection<SysClientUnitSchemaSource> SysClientUnitSchemaSources { get; set; } = new List<SysClientUnitSchemaSource>();

    public virtual ICollection<SysEditPage> SysEditPageSysEntitySchemas { get; set; } = new List<SysEditPage>();

    public virtual ICollection<SysEditPage> SysEditPageSysPageSchemas { get; set; } = new List<SysEditPage>();

    public virtual ICollection<SysEntityPrcStartEvent> SysEntityPrcStartEvents { get; set; } = new List<SysEntityPrcStartEvent>();

    public virtual ICollection<SysEntitySchemaReference> SysEntitySchemaReferenceReferenceSchemas { get; set; } = new List<SysEntitySchemaReference>();

    public virtual ICollection<SysEntitySchemaReference> SysEntitySchemaReferenceSysSchemas { get; set; } = new List<SysEntitySchemaReference>();

    public virtual ICollection<SysGridPage> SysGridPageSysEntitySchemas { get; set; } = new List<SysGridPage>();

    public virtual ICollection<SysGridPage> SysGridPageSysPageSchemas { get; set; } = new List<SysGridPage>();

    public virtual ICollection<SysInstalledPackageDatum> SysInstalledPackageData { get; set; } = new List<SysInstalledPackageDatum>();

    public virtual ICollection<SysLocalizableValue> SysLocalizableValues { get; set; } = new List<SysLocalizableValue>();

    public virtual ICollection<SysModuleGridEditPage> SysModuleGridEditPageSysEditPageSchemas { get; set; } = new List<SysModuleGridEditPage>();

    public virtual ICollection<SysModuleGridEditPage> SysModuleGridEditPageSysModuleGridPages { get; set; } = new List<SysModuleGridEditPage>();

    public virtual SysPackage? SysPackage { get; set; }

    public virtual ICollection<SysPackageResourceChecksum> SysPackageResourceChecksums { get; set; } = new List<SysPackageResourceChecksum>();

    public virtual ICollection<SysPackageSchemaDatum> SysPackageSchemaData { get; set; } = new List<SysPackageSchemaDatum>();

    public virtual ICollection<SysPrcActualVersion> SysPrcActualVersionActualVersionSchemas { get; set; } = new List<SysPrcActualVersion>();

    public virtual ICollection<SysPrcActualVersion> SysPrcActualVersionRootVersionSchemas { get; set; } = new List<SysPrcActualVersion>();

    public virtual ICollection<SysProcessDatum> SysProcessData { get; set; } = new List<SysProcessDatum>();

    public virtual SysProcessDisabled? SysProcessDisabled { get; set; }

    public virtual ICollection<SysSchemaContent> SysSchemaContents { get; set; } = new List<SysSchemaContent>();

    public virtual ICollection<SysSchemaLcz> SysSchemaLczs { get; set; } = new List<SysSchemaLcz>();

    public virtual ICollection<SysSchemaProperty> SysSchemaProperties { get; set; } = new List<SysSchemaProperty>();

    public virtual ICollection<SysSspcustomerSchema> SysSspcustomerSchemas { get; set; } = new List<SysSspcustomerSchema>();
}
