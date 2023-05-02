﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcActualVersion
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? RootVersionSchemaId { get; set; }

    public Guid? ActualVersionSchemaId { get; set; }

    public virtual SysSchema? ActualVersionSchema { get; set; }

    public virtual SysSchema? RootVersionSchema { get; set; }
}
