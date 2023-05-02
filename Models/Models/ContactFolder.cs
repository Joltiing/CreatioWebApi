using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactFolder
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

    public virtual ICollection<ContactInFolder> ContactInFolders { get; set; } = new List<ContactInFolder>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<ContactFolder> InverseParent { get; set; } = new List<ContactFolder>();

    public virtual ICollection<MailboxContactFolder> MailboxContactFolders { get; set; } = new List<MailboxContactFolder>();

    public virtual ContactFolder? Parent { get; set; }

    public virtual ICollection<SysContactFolderLcz> SysContactFolderLczs { get; set; } = new List<SysContactFolderLcz>();

    public virtual ICollection<SysContactFolderRight> SysContactFolderRights { get; set; } = new List<SysContactFolderRight>();
}
