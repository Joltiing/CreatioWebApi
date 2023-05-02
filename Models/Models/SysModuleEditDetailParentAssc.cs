using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleEditDetailParentAssc
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysModuleEditDetailId { get; set; }

    public string ColumnMetaPath { get; set; } = null!;

    public string ParentColumnMetaPath { get; set; } = null!;

    public Guid? SysParentAssociationTypeId { get; set; }

    public string ColumnCaption { get; set; } = null!;

    public string ParentColumnCaption { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual SysModuleEditDetail? SysModuleEditDetail { get; set; }

    public virtual SysParentAssociationType? SysParentAssociationType { get; set; }
}
