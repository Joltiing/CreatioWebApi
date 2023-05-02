using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactAddress
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? AddressTypeId { get; set; }

    public Guid? CountryId { get; set; }

    public Guid? RegionId { get; set; }

    public Guid? CityId { get; set; }

    public string Address { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public bool Primary { get; set; }

    public Guid? ContactId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual AddressType? AddressType { get; set; }

    public virtual City? City { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Region? Region { get; set; }
}
