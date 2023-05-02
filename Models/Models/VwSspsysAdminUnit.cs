using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSspsysAdminUnit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentRoleId { get; set; }

    public Guid? ContactId { get; set; }

    public string TimeZoneId { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int SysAdminUnitTypeValue { get; set; }

    public Guid? AccountId { get; set; }

    public bool Active { get; set; }

    public bool LoggedIn { get; set; }

    public bool SynchronizeWithLdap { get; set; }

    public string Ldapentry { get; set; } = null!;

    public string LdapentryId { get; set; } = null!;

    public string LdapentryDn { get; set; } = null!;

    public bool IsDirectoryEntry { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysCultureId { get; set; }

    public int LoginAttemptCount { get; set; }

    public string SourceControlLogin { get; set; } = null!;

    public string SourceControlPassword { get; set; } = null!;

    public DateTime? PasswordExpireDate { get; set; }

    public Guid? HomePageId { get; set; }

    public int ConnectionType { get; set; }
}
