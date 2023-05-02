using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwEntityInProcess
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string EntitySchemaName { get; set; } = null!;

    public Guid? RecordId { get; set; }

    public string ProcessCaption { get; set; } = null!;

    public string ProcessDescription { get; set; } = null!;
}
