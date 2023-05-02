using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwReminding
{
    public Guid Id { get; set; }

    public string SubjectCaption { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? AuthorId { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? SourceId { get; set; }

    public DateTime? RemindTime { get; set; }

    public string Description { get; set; } = null!;

    public Guid? SubjectId { get; set; }

    public Guid? SysEntitySchemaId { get; set; }

    public string TypeCaption { get; set; } = null!;

    public string Hash { get; set; } = null!;
}
