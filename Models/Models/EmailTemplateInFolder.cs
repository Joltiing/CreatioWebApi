using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailTemplateInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EmailTemplateId { get; set; }

    public virtual EmailTemplate? EmailTemplate { get; set; }

    public virtual EmailTemplateFolder? Folder { get; set; }

    public virtual ICollection<SysEmailTemplateInFolderRight> SysEmailTemplateInFolderRights { get; set; } = new List<SysEmailTemplateInFolderRight>();
}
