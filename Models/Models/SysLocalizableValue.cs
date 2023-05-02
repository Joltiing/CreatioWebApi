using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLocalizableValue
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? SysSchemaId { get; set; }

    public string ResourceManager { get; set; } = null!;

    public Guid? SysCultureId { get; set; }

    public int ResourceType { get; set; }

    public bool IsChanged { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public byte[]? ImageData { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysCulture? SysCulture { get; set; }

    public virtual SysPackage? SysPackage { get; set; }

    public virtual SysSchema? SysSchema { get; set; }
}
