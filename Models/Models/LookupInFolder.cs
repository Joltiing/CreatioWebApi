using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LookupInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? FolderId { get; set; }

    public Guid? LookupId { get; set; }

    public virtual LookupFolder? Folder { get; set; }

    public virtual Lookup? Lookup { get; set; }
}
