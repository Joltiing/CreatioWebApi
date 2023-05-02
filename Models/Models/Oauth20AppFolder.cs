using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Oauth20AppFolder
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

    public virtual ICollection<Oauth20AppFolder> InverseParent { get; set; } = new List<Oauth20AppFolder>();

    public virtual ICollection<Oauth20AppInFolder> Oauth20AppInFolders { get; set; } = new List<Oauth20AppInFolder>();

    public virtual Oauth20AppFolder? Parent { get; set; }

    public virtual ICollection<SysOauth20AppFolderLcz> SysOauth20AppFolderLczs { get; set; } = new List<SysOauth20AppFolderLcz>();

    public virtual ICollection<SysOauth20AppFolderRight> SysOauth20AppFolderRights { get; set; } = new List<SysOauth20AppFolderRight>();
}
