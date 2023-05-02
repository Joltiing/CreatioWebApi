using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwModuleHistory
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Title { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public Guid? SysEntityId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? ContactId { get; set; }
}
