using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AddressType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool ForContact { get; set; }

    public bool ForAccount { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<AccountAddress> AccountAddresses { get; set; } = new List<AccountAddress>();

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<ContactAddress> ContactAddresses { get; set; } = new List<ContactAddress>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<SysAddressTypeLcz> SysAddressTypeLczs { get; set; } = new List<SysAddressTypeLcz>();
}
