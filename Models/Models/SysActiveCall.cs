using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysActiveCall
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string IntegrationId { get; set; } = null!;

    public Guid? CallId { get; set; }

    public Guid? ParentCallId { get; set; }

    public string CallerId { get; set; } = null!;

    public string CalledId { get; set; } = null!;

    public string RedirectingId { get; set; } = null!;

    public string RedirectionId { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? CurrentHoldStartTime { get; set; }

    public DateTime? CurrentTalkStartTime { get; set; }

    public DateTime? ConnectionStartTime { get; set; }

    public int Duration { get; set; }

    public int BeforeConnectionTime { get; set; }

    public int TalkTime { get; set; }

    public int HoldTime { get; set; }

    public string State { get; set; } = null!;

    public string CallContext { get; set; } = null!;

    public string CallContextType { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? DirectionId { get; set; }

    public virtual Call? Call { get; set; }

    public virtual CallDirection? Direction { get; set; }

    public virtual Call? ParentCall { get; set; }
}
