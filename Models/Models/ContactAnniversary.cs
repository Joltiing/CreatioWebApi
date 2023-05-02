using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactAnniversary
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public DateTime? Date { get; set; }

    public Guid? AnniversaryTypeId { get; set; }

    public string Description { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public virtual AnniversaryType? AnniversaryType { get; set; }

    public virtual Contact? Contact { get; set; }
}
