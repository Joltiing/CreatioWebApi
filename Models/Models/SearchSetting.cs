using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SearchSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Settings { get; set; } = null!;

    public Guid? SearchEntityId { get; set; }

    public string Name { get; set; } = null!;
}
