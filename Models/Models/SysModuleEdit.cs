using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleEdit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysModuleEntityId { get; set; }

    public Guid? TypeColumnValue { get; set; }

    public bool UseModuleDetails { get; set; }

    public int Position { get; set; }

    public string HelpContextId { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? SysPageSchemaUid { get; set; }

    public Guid? CardSchemaUid { get; set; }

    public string ActionKindCaption { get; set; } = null!;

    public string ActionKindName { get; set; } = null!;

    public string PageCaption { get; set; } = null!;

    public Guid? MiniPageSchemaUid { get; set; }

    public Guid? SearchRowSchemaUid { get; set; }

    public string MiniPageModes { get; set; } = null!;

    public virtual ICollection<QuickAddMenuItem> QuickAddMenuItems { get; set; } = new List<QuickAddMenuItem>();

    public virtual ICollection<SysModuleEditDetail> SysModuleEditDetails { get; set; } = new List<SysModuleEditDetail>();

    public virtual ICollection<SysModuleEditLczOld> SysModuleEditLczOlds { get; set; } = new List<SysModuleEditLczOld>();

    public virtual ICollection<SysModuleEditLcz> SysModuleEditLczs { get; set; } = new List<SysModuleEditLcz>();

    public virtual SysModuleEntity? SysModuleEntity { get; set; }
}
