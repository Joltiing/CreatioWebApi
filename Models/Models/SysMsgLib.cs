using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysMsgLib
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string FullClassName { get; set; } = null!;

    public string SetupPageSchemaName { get; set; } = null!;

    public string LicOperations { get; set; } = null!;

    public string CtiProviderName { get; set; } = null!;

    public virtual ICollection<SysMsgLibLcz> SysMsgLibLczs { get; set; } = new List<SysMsgLibLcz>();

    public virtual ICollection<SysMsgUserSetting> SysMsgUserSettings { get; set; } = new List<SysMsgUserSetting>();

    public virtual ICollection<SysMsgUserStateInLib> SysMsgUserStateInLibs { get; set; } = new List<SysMsgUserStateInLib>();
}
