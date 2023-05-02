﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VisaStatus
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public bool IsFinal { get; set; }

    public virtual ICollection<SysVisaStatusLcz> SysVisaStatusLczs { get; set; } = new List<SysVisaStatusLcz>();
}