using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwModuleEditInfo
{
    public Guid? Id { get; set; }

    public string ModuleCode { get; set; } = null!;

    public Guid? TypeColumnValue { get; set; }

    public string Name { get; set; } = null!;

    public Guid? WorkspaceId { get; set; }

    public Guid RecordId { get; set; }

    public Guid? ActionKindCaptionLczId { get; set; }

    public Guid? PageCaptionLczId { get; set; }

    public string? PageCaptionLczOld { get; set; }

    public string? PageCaptionLcz { get; set; }

    public string DefaultPageCaption { get; set; } = null!;

    public Guid? CultureId { get; set; }

    public int Position { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
