﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityTypeStatusEntry
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ActivityTypeId { get; set; }

    public Guid? ActivityStatusId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ActivityStatus? ActivityStatus { get; set; }

    public virtual ActivityType? ActivityType { get; set; }
}
