using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class City
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? CountryId { get; set; }

    public Guid? RegionId { get; set; }

    public Guid? TimeZoneId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<AccountAddress> AccountAddresses { get; set; } = new List<AccountAddress>();

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<ContactAddress> ContactAddresses { get; set; } = new List<ContactAddress>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<FormSubmit> FormSubmits { get; set; } = new List<FormSubmit>();

    public virtual Region? Region { get; set; }

    public virtual ICollection<SysCityLcz> SysCityLczs { get; set; } = new List<SysCityLcz>();

    public virtual ICollection<SysModuleFolder> SysModuleFolders { get; set; } = new List<SysModuleFolder>();

    public virtual TimeZone? TimeZone { get; set; }

    public virtual ICollection<Touch> Touches { get; set; } = new List<Touch>();
}
