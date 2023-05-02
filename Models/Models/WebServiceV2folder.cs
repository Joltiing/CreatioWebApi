using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WebServiceV2folder
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Description { get; set; } = null!;

    public Guid? FolderTypeId { get; set; }

    public byte[]? SearchData { get; set; }

    public int OptimizationType { get; set; }

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<WebServiceV2folder> InverseParent { get; set; } = new List<WebServiceV2folder>();

    public virtual WebServiceV2folder? Parent { get; set; }

    public virtual ICollection<SysWebServiceV2folderLcz> SysWebServiceV2folderLczs { get; set; } = new List<SysWebServiceV2folderLcz>();

    public virtual ICollection<SysWebServiceV2folderRight> SysWebServiceV2folderRights { get; set; } = new List<SysWebServiceV2folderRight>();

    public virtual ICollection<WebServiceV2inFolder> WebServiceV2inFolders { get; set; } = new List<WebServiceV2inFolder>();
}
