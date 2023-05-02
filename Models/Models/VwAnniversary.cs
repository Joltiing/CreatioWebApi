using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwAnniversary
{
    public Guid Id { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? SysEntityId { get; set; }

    public Guid? AnniversaryTypeId { get; set; }
}
