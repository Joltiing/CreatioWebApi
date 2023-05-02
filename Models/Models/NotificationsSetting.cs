using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class NotificationsSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysImageId { get; set; }

    public Guid? NotificationTypeId { get; set; }

    public Guid? SysEntitySchemaUid { get; set; }

    public virtual NotificationType? NotificationType { get; set; }

    public virtual SysImage? SysImage { get; set; }
}
