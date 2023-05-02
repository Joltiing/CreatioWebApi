using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DuplicatesSearchParameter
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public bool PerformSearchOnSave { get; set; }

    public bool PerformSheduledSearch { get; set; }

    public TimeSpan? SearchTime { get; set; }

    public bool SearchByModifiedOnly { get; set; }

    public bool SearchByAll { get; set; }

    public int Days { get; set; }

    public Guid? SchemaToSearch { get; set; }

    public int ProcessListeners { get; set; }

    public string SchemaToSearchName { get; set; } = null!;
}
