using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class GlobalDuplicateSearchState
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int EntityRowNumber { get; set; }

    public Guid? SchemaToSearchId { get; set; }

    public int ProcessedCount { get; set; }

    public Guid? SearchStatusId { get; set; }

    public DateTime? SearchStatusChangedOn { get; set; }

    public int TotalCount { get; set; }

    public bool IsManuallyTriggered { get; set; }

    public int ProcessListeners { get; set; }

    public string SchemaToSearchName { get; set; } = null!;

    public virtual GlobalDuplicateSearchStatus? SearchStatus { get; set; }
}
