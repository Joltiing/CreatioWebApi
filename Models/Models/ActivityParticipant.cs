using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityParticipant
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ActivityId { get; set; }

    public Guid? ParticipantId { get; set; }

    public string Description { get; set; } = null!;

    public Guid? RoleId { get; set; }

    public bool ReadMark { get; set; }

    public int ProcessListeners { get; set; }

    public bool InviteParticipant { get; set; }

    public Guid? InviteResponseId { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual ParticipantResponse? InviteResponse { get; set; }

    public virtual Contact? Participant { get; set; }

    public virtual ActivityParticipantRole? Role { get; set; }
}
