using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityFolder
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

    public Guid? FolderEmbeddedProcessId { get; set; }

    public bool Synchronize { get; set; }

    public int OptimizationType { get; set; }

    public virtual ICollection<ActivityInFolder> ActivityInFolders { get; set; } = new List<ActivityInFolder>();

    public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettings { get; set; } = new List<EmailFolderColumnValuesSetting>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<ActivityFolder> InverseParent { get; set; } = new List<ActivityFolder>();

    public virtual ICollection<MailboxFoldersCorrespondence> MailboxFoldersCorrespondences { get; set; } = new List<MailboxFoldersCorrespondence>();

    public virtual ActivityFolder? Parent { get; set; }

    public virtual ICollection<SysActivityFolderLcz> SysActivityFolderLczs { get; set; } = new List<SysActivityFolderLcz>();

    public virtual ICollection<SysActivityFolderRight> SysActivityFolderRights { get; set; } = new List<SysActivityFolderRight>();
}
