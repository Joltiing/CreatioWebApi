﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Esnnotification
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public bool IsRead { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? SocialMessageId { get; set; }

    public virtual Contact? Owner { get; set; }

    public virtual SocialMessage? SocialMessage { get; set; }

    public virtual EsnnotificationType? Type { get; set; }
}
