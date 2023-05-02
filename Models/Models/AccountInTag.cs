using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountInTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TagId { get; set; }

    public Guid? EntityId { get; set; }

    public virtual Account? Entity { get; set; }

    public virtual AccountTag? Tag { get; set; }
}
