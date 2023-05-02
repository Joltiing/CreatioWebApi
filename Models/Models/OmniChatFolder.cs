using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OmniChatFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public Guid? FolderTypeId { get; set; }

    public byte[]? SearchData { get; set; }

    public int ProcessListeners { get; set; }

    public int OptimizationType { get; set; }

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<OmniChatFolder> InverseParent { get; set; } = new List<OmniChatFolder>();

    public virtual ICollection<OmniChatInFolder> OmniChatInFolders { get; set; } = new List<OmniChatInFolder>();

    public virtual OmniChatFolder? Parent { get; set; }

    public virtual ICollection<SysOmniChatFolderLcz> SysOmniChatFolderLczs { get; set; } = new List<SysOmniChatFolderLcz>();

    public virtual ICollection<SysOmniChatFolderRight> SysOmniChatFolderRights { get; set; } = new List<SysOmniChatFolderRight>();
}
