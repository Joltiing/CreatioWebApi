using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SyncErrorHandler
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string ExceptionClass { get; set; } = null!;

    public string MessageFilter { get; set; } = null!;

    public int RetryCount { get; set; }

    public Guid? ErrorCodeId { get; set; }

    public bool NotStopSyncing { get; set; }

    public virtual SyncErrorMessage? ErrorCode { get; set; }

    public virtual ICollection<SysSyncErrorHandlerLcz> SysSyncErrorHandlerLczs { get; set; } = new List<SysSyncErrorHandlerLcz>();
}
