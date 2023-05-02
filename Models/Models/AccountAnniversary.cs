using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountAnniversary
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? Date { get; set; }

    public Guid? AnniversaryTypeId { get; set; }

    public Guid? AccountId { get; set; }

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual Account? Account { get; set; }

    public virtual AnniversaryType? AnniversaryType { get; set; }
}
