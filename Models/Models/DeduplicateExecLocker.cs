using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DeduplicateExecLocker
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string EntitySchemaName { get; set; } = null!;

    public Guid? ConversationId { get; set; }

    public Guid? OperationId { get; set; }

    public bool IsInProgress { get; set; }

    public virtual DeduplicateExecLog? Conversation { get; set; }

    public virtual DeduplicateOperation? Operation { get; set; }
}
