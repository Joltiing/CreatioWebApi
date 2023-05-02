using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountDuplicateSearchResult
{
    public Guid? AccountId { get; set; }

    public int? GroupId { get; set; }

    public Guid? RuleId { get; set; }

    public Guid? GroupHash { get; set; }

    public Guid? SysAdminUnitId { get; set; }
}
