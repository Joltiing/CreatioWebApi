using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmployeeFolder
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

    public virtual ICollection<EmployeeInFolder> EmployeeInFolders { get; set; } = new List<EmployeeInFolder>();

    public virtual FolderType? FolderType { get; set; }

    public virtual ICollection<EmployeeFolder> InverseParent { get; set; } = new List<EmployeeFolder>();

    public virtual EmployeeFolder? Parent { get; set; }

    public virtual ICollection<SysEmployeeFolderLcz> SysEmployeeFolderLczs { get; set; } = new List<SysEmployeeFolderLcz>();

    public virtual ICollection<SysEmployeeFolderRight> SysEmployeeFolderRights { get; set; } = new List<SysEmployeeFolderRight>();
}
