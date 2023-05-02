using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Call
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string IntegrationId { get; set; } = null!;

    public string ParentCallId { get; set; } = null!;

    public string CallerId { get; set; } = null!;

    public string CalledId { get; set; } = null!;

    public string RedirectingId { get; set; } = null!;

    public string RedirectionId { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int Duration { get; set; }

    public int BeforeConnectionTime { get; set; }

    public int TalkTime { get; set; }

    public int HoldTime { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? DirectionId { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? ResultId { get; set; }

    public string Comment { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public Guid? ActivityId { get; set; }

    public string GloballyUniqueCallLinkageId { get; set; } = null!;

    public virtual Account? Account { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual ICollection<CallFile> CallFiles { get; set; } = new List<CallFile>();

    public virtual ICollection<CallInFolder> CallInFolders { get; set; } = new List<CallInFolder>();

    public virtual ICollection<CallInTag> CallInTags { get; set; } = new List<CallInTag>();

    public virtual Contact? Contact { get; set; }

    public virtual CallDirection? Direction { get; set; }

    public virtual ActivityResult? Result { get; set; }

    public virtual ICollection<SysActiveCall> SysActiveCallCalls { get; set; } = new List<SysActiveCall>();

    public virtual ICollection<SysActiveCall> SysActiveCallParentCalls { get; set; } = new List<SysActiveCall>();
}
