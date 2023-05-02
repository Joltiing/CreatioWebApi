using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class CallInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? CallId { get; set; }

    public virtual Call? Call { get; set; }

    public virtual CallFolder? Folder { get; set; }
}
