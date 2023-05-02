using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessLog
{
    public string Name { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? CompleteDate { get; set; }

    public Guid? SysSchemaId { get; set; }

    public Guid? StatusId { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public decimal DurationInMinutes { get; set; }

    public decimal DurationInHours { get; set; }

    public decimal DurationInDays { get; set; }

    public string PackageName { get; set; } = null!;

    public int Version { get; set; }

    public string ErrorDescription { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public decimal DurationInMilliseconds { get; set; }

    public string ClientIp { get; set; } = null!;

    public virtual SysProcessStatus? Status { get; set; }

    public virtual ICollection<SysProcessElementLog> SysProcessElementLogs { get; set; } = new List<SysProcessElementLog>();

    public virtual ICollection<SysProcessLogInFolder> SysProcessLogInFolders { get; set; } = new List<SysProcessLogInFolder>();
}
