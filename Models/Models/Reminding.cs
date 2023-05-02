using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Reminding
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? AuthorId { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? SourceId { get; set; }

    public DateTime? RemindTime { get; set; }

    public string Description { get; set; } = null!;

    public Guid? SubjectId { get; set; }

    public Guid? SysEntitySchemaId { get; set; }

    public int ProcessListeners { get; set; }

    public string SubjectCaption { get; set; } = null!;

    public string TypeCaption { get; set; } = null!;

    public string PopupTitle { get; set; } = null!;

    public string Hash { get; set; } = null!;

    public bool IsRead { get; set; }

    public Guid? NotificationTypeId { get; set; }

    public Guid? LoaderId { get; set; }

    public Guid? SenderId { get; set; }

    public bool IsNeedToSend { get; set; }

    public DateTime? AnniversaryDate { get; set; }

    public string Config { get; set; } = null!;

    public virtual Contact? Author { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual NotificationType? NotificationType { get; set; }

    public virtual RemindingSource? Source { get; set; }
}
