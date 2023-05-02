using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SocialChannelFolder
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

    public virtual ICollection<SocialChannelFolder> InverseParent { get; set; } = new List<SocialChannelFolder>();

    public virtual SocialChannelFolder? Parent { get; set; }

    public virtual ICollection<SocialChannelInFolder> SocialChannelInFolders { get; set; } = new List<SocialChannelInFolder>();

    public virtual ICollection<SysSocialChannelFolderLcz> SysSocialChannelFolderLczs { get; set; } = new List<SysSocialChannelFolderLcz>();

    public virtual ICollection<SysSocialChannelFolderRight> SysSocialChannelFolderRights { get; set; } = new List<SysSocialChannelFolderRight>();
}
