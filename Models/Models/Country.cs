using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Country
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte[]? Image { get; set; }

    public string BillingInfo { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? TimeZoneId { get; set; }

    public string Code { get; set; } = null!;

    public string Alpha2Code { get; set; } = null!;

    public virtual ICollection<AccountAddress> AccountAddresses { get; set; } = new List<AccountAddress>();

    public virtual ICollection<AccountBillingInfo> AccountBillingInfos { get; set; } = new List<AccountBillingInfo>();

    public virtual ICollection<AccountOwnership> AccountOwnerships { get; set; } = new List<AccountOwnership>();

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<ContactAddress> ContactAddresses { get; set; } = new List<ContactAddress>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<DialingCode> DialingCodes { get; set; } = new List<DialingCode>();

    public virtual ICollection<FormSubmit> FormSubmits { get; set; } = new List<FormSubmit>();

    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();

    public virtual ICollection<SysCountryLcz> SysCountryLczs { get; set; } = new List<SysCountryLcz>();

    public virtual TimeZone? TimeZone { get; set; }

    public virtual ICollection<Touch> Touches { get; set; } = new List<Touch>();
}
