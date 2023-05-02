using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EnrchFoundAccount
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EnrchTextEntityId { get; set; }

    public Guid? AccountId { get; set; }

    public string IdentificationType { get; set; } = null!;

    public virtual Account? Account { get; set; }

    public virtual EnrchTextEntity? EnrchTextEntity { get; set; }
}
