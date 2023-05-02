using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailFolderColumnValuesSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EmailFolderId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? ContactId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual ActivityFolder? EmailFolder { get; set; }
}
