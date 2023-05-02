﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class QrtzSchedulerState
{
    public string SchedName { get; set; } = null!;

    public string InstanceName { get; set; } = null!;

    public long LastCheckinTime { get; set; }

    public long CheckinInterval { get; set; }
}