using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Position { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public Guid? Uid { get; set; }

    public string Version { get; set; } = null!;

    public string Maintainer { get; set; } = null!;

    public bool Essential { get; set; }

    public string Annotation { get; set; } = null!;

    public bool IsChanged { get; set; }

    public bool IsLocked { get; set; }

    public int InstallType { get; set; }

    public int RepositoryRevisionNumber { get; set; }

    public Guid? SysRepositoryId { get; set; }

    public int ProcessListeners { get; set; }

    public int Type { get; set; }

    public string ProjectPath { get; set; } = null!;

    public virtual ICollection<SysInstalledPackageDatum> SysInstalledPackageData { get; set; } = new List<SysInstalledPackageDatum>();

    public virtual ICollection<SysLocalizableValue> SysLocalizableValues { get; set; } = new List<SysLocalizableValue>();

    public virtual ICollection<SysPackageDependency> SysPackageDependencyDependOnPackages { get; set; } = new List<SysPackageDependency>();

    public virtual ICollection<SysPackageDependency> SysPackageDependencySysPackages { get; set; } = new List<SysPackageDependency>();

    public virtual ICollection<SysPackageHierarchy> SysPackageHierarchyBaseSysPackages { get; set; } = new List<SysPackageHierarchy>();

    public virtual ICollection<SysPackageHierarchy> SysPackageHierarchyDependOnPackages { get; set; } = new List<SysPackageHierarchy>();

    public virtual ICollection<SysPackageHierarchy> SysPackageHierarchySysPackages { get; set; } = new List<SysPackageHierarchy>();

    public virtual ICollection<SysPackageInInstalledApp> SysPackageInInstalledApps { get; set; } = new List<SysPackageInInstalledApp>();

    public virtual ICollection<SysPackageReferenceAssembly> SysPackageReferenceAssemblies { get; set; } = new List<SysPackageReferenceAssembly>();

    public virtual ICollection<SysPackageResourceChecksum> SysPackageResourceChecksums { get; set; } = new List<SysPackageResourceChecksum>();

    public virtual ICollection<SysPackageSchemaDatum> SysPackageSchemaData { get; set; } = new List<SysPackageSchemaDatum>();

    public virtual ICollection<SysPackageSqlScript> SysPackageSqlScripts { get; set; } = new List<SysPackageSqlScript>();

    public virtual SysRepository? SysRepository { get; set; }

    public virtual ICollection<SysSchema> SysSchemas { get; set; } = new List<SysSchema>();

    public virtual SysWorkspace? SysWorkspace { get; set; }
}
