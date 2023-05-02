using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SocialLike
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? UserId { get; set; }

    public Guid? SocialMessageId { get; set; }

    public virtual SocialMessage? SocialMessage { get; set; }

    public virtual SysAdminUnit? User { get; set; }
}
