using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ResolvedLookupConflict
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string LookupSchemaName { get; set; } = null!;

    public string LookupSchemaDisplayColumnName { get; set; } = null!;

    public string LookupSchemaDisplayColumnValue { get; set; } = null!;

    public Guid? LookupRecordId { get; set; }
}
