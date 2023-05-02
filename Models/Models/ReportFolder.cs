using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ReportFolder
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

    public virtual ICollection<ReportFolder> InverseParent { get; set; } = new List<ReportFolder>();

    public virtual ReportFolder? Parent { get; set; }

    public virtual ICollection<ReportInFolder> ReportInFolders { get; set; } = new List<ReportInFolder>();

    public virtual ICollection<SysReportFolderLcz> SysReportFolderLczs { get; set; } = new List<SysReportFolderLcz>();
}
