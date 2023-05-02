using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SocialMessageEntity
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SocialMessageId { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public Guid? EntityId { get; set; }

    public virtual SocialMessage? SocialMessage { get; set; }
}
