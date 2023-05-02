using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwCommandAction
{
    public string? Id { get; set; }

    public Guid CommandActionId { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int ProcessListeners { get; set; }

    public string Caption { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? ColumnCaption { get; set; }

    public Guid? SubjectColumnUid { get; set; }

    public Guid? SubjectSchemaUid { get; set; }

    public string MainParamCation { get; set; } = null!;

    public string AdditionalParamValue { get; set; } = null!;

    public int OrderColumn { get; set; }

    public Guid? TypeColumnUid { get; set; }

    public string TypeColumnCode { get; set; } = null!;

    public int IsShared { get; set; }
}
