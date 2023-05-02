using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WebServiceV2inFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? FolderId { get; set; }

    public Guid? WebServiceV2id { get; set; }

    public virtual WebServiceV2folder? Folder { get; set; }

    public virtual ICollection<SysWebServiceV2inFolderRight> SysWebServiceV2inFolderRights { get; set; } = new List<SysWebServiceV2inFolderRight>();
}
