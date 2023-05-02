﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysMsgUserStateInLib
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysMsgLibId { get; set; }

    public Guid? SysMsgUserStateId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysMsgLib? SysMsgLib { get; set; }

    public virtual SysMsgUserState? SysMsgUserState { get; set; }
}
