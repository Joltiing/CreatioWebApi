using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DuplicatesHistory
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? OldRecordId { get; set; }

    public Guid? NewRecordId { get; set; }

    public string SchemaTableName { get; set; } = null!;
}
