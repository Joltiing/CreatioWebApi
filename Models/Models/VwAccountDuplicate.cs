using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwAccountDuplicate
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Entity1Id { get; set; }

    public Guid? Entity2Id { get; set; }

    public Guid? StatusOfDuplicateId { get; set; }

    public int ProcessListeners { get; set; }
}
