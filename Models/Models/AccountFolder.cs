using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountFolder
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

    public virtual ICollection<AccountInFolder> AccountInFolders { get; set; } = new List<AccountInFolder>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<AccountFolder> InverseParent { get; set; } = new List<AccountFolder>();

    public virtual AccountFolder? Parent { get; set; }

    public virtual ICollection<SysAccountFolderLcz> SysAccountFolderLczs { get; set; } = new List<SysAccountFolderLcz>();

    public virtual ICollection<SysAccountFolderRight> SysAccountFolderRights { get; set; } = new List<SysAccountFolderRight>();
}
