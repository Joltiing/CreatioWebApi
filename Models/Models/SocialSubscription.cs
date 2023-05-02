using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SocialSubscription
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public Guid? EntityId { get; set; }

    public bool CanUnsubscribe { get; set; }

    public DateTime? RightsChangedOn { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }

    public virtual ICollection<SysSocialSubscriptionRight> SysSocialSubscriptionRights { get; set; } = new List<SysSocialSubscriptionRight>();
}
