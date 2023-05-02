using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysTranslationFolderRight
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public int Operation { get; set; }

    public int RightLevel { get; set; }

    public int Position { get; set; }

    public Guid? SourceId { get; set; }

    public virtual SysTranslationFolder? Record { get; set; }

    public virtual SysEntitySchemaRecRightSource? Source { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
