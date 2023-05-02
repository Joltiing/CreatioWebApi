using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLic
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysLicPackageId { get; set; }

    public int Count { get; set; }

    public DateTime? DueDate { get; set; }

    public string Key { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public int LicType { get; set; }

    public int SspschemaCount { get; set; }

    public int SspadministratedSchemaCount { get; set; }

    public int SspcustomEntityCount { get; set; }

    public int ProcessListeners { get; set; }

    public string LicVersion { get; set; } = null!;

    public virtual SysLicPackage? SysLicPackage { get; set; }
}
