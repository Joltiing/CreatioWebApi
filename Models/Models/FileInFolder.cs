using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FileInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public Guid? FileId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual File? File { get; set; }

    public virtual FileFolder? Folder { get; set; }
}
