using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessElementToDo
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public DateTime? StartDate { get; set; }

    public string Title { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public Guid? SysProcessDataId { get; set; }

    public string ManagerName { get; set; } = null!;

    public Guid? ProcessSchemaUid { get; set; }

    public Guid? ElementSchemaUid { get; set; }

    public byte[]? ExecutionData { get; set; }

    public byte[]? ExtraData { get; set; }

    public int GroupType { get; set; }

    public Guid? GroupId { get; set; }
}
