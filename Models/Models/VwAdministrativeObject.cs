using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwAdministrativeObject
{
    public Guid? Id { get; set; }

    public Guid? Uid { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int IsLookup { get; set; }

    public int IsModule { get; set; }

    public int? AdministratedByOperations { get; set; }

    public int? AdministratedByColumns { get; set; }

    public int? AdministratedByRecords { get; set; }

    public int? IsTrackChangesInDb { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public int ProcessListeners { get; set; }

    public int IsInSspentitySchemaAccessList { get; set; }
}
