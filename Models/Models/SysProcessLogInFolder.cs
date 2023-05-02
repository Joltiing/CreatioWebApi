using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessLogInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public Guid? SysProcessLogId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysProcessLogFolder? Folder { get; set; }

    public virtual SysProcessLog? SysProcessLog { get; set; }
}
