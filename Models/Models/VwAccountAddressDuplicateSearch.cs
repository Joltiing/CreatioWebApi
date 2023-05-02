using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwAccountAddressDuplicateSearch
{
    public Guid AccountAddressId { get; set; }

    public Guid AccountId { get; set; }

    public DateTime? AccountModifiedOn { get; set; }

    public Guid? CityId { get; set; }
}
