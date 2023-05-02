﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountCategory
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<SysAccountCategoryLcz> SysAccountCategoryLczs { get; set; } = new List<SysAccountCategoryLcz>();
}
