using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysAdminUnit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentRoleId { get; set; }

    public Guid? ContactId { get; set; }

    public bool IsDirectoryEntry { get; set; }

    public Guid? TimeZoneId { get; set; }

    public string UserPassword { get; set; } = null!;

    public Guid SysAdminUnitTypeId { get; set; }

    public Guid? AccountId { get; set; }

    public bool Active { get; set; }

    public bool LoggedIn { get; set; }

    public bool SynchronizeWithLdap { get; set; }

    public string? Ldapentry { get; set; }

    public string? LdapentryId { get; set; }

    public string? LdapentryDn { get; set; }

    public Guid? SysCultureId { get; set; }

    public int ProcessListeners { get; set; }

    public DateTime? PasswordExpireDate { get; set; }

    public Guid? HomePageId { get; set; }

    public int ConnectionType { get; set; }

    public Guid? UserConnectionTypeId { get; set; }

    public bool ForceChangePassword { get; set; }

    public Guid? LdapelementId { get; set; }

    public Guid? DateTimeFormatId { get; set; }

    public Guid SysAdminUnitId { get; set; }

    public int SessionTimeout { get; set; }
}
