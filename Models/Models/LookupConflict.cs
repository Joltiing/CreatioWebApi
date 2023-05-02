using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LookupConflict
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string DestinationSchemaName { get; set; } = null!;

    public Guid? DestinationRecordId { get; set; }

    public string DestinationColumnName { get; set; } = null!;

    public string LookupSchemaName { get; set; } = null!;

    public string LookupSchemaDisplayColumnName { get; set; } = null!;

    public string LookupSchemaDisplayColumnValue { get; set; } = null!;

    public Guid? LookupRecordId { get; set; }
}
