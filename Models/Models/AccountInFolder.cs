using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public Guid? AccountId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Account? Account { get; set; }

    public virtual AccountFolder? Folder { get; set; }
}
