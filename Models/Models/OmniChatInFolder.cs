using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OmniChatInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? OmniChatId { get; set; }

    public virtual OmniChatFolder? Folder { get; set; }

    public virtual OmniChat? OmniChat { get; set; }

    public virtual ICollection<SysOmniChatInFolderRight> SysOmniChatInFolderRights { get; set; } = new List<SysOmniChatInFolderRight>();
}
