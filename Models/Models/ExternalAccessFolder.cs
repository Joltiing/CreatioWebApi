using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExternalAccessFolder
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

    public virtual ICollection<ExternalAccessInFolder> ExternalAccessInFolders { get; set; } = new List<ExternalAccessInFolder>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<ExternalAccessFolder> InverseParent { get; set; } = new List<ExternalAccessFolder>();

    public virtual ExternalAccessFolder? Parent { get; set; }

    public virtual ICollection<SysExternalAccessFolderLcz> SysExternalAccessFolderLczs { get; set; } = new List<SysExternalAccessFolderLcz>();

    public virtual ICollection<SysExternalAccessFolderRight> SysExternalAccessFolderRights { get; set; } = new List<SysExternalAccessFolderRight>();
}
