using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EntityConnection
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysEntitySchemaUid { get; set; }

    public Guid? ColumnUid { get; set; }

    public int Position { get; set; }
}
