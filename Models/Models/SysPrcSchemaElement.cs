using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcSchemaElement
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Uid { get; set; }

    public Guid? ProcessUid { get; set; }

    public string Name { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public int StartType { get; set; }
}
