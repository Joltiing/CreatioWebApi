using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailTemplateMacro
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public int Position { get; set; }

    public Guid? ParentId { get; set; }

    public string ColumnPath { get; set; } = null!;

    public Guid? AccountCommunicationTypeId { get; set; }

    public string Code { get; set; } = null!;

    public bool IsInactive { get; set; }

    public virtual CommunicationType? AccountCommunicationType { get; set; }

    public virtual ICollection<EmailTemplateMacro> InverseParent { get; set; } = new List<EmailTemplateMacro>();

    public virtual EmailTemplateMacro? Parent { get; set; }

    public virtual ICollection<SysEmailTemplateMacrosLcz> SysEmailTemplateMacrosLczs { get; set; } = new List<SysEmailTemplateMacrosLcz>();
}
