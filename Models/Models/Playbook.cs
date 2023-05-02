using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Playbook
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? CultureId { get; set; }

    public Guid? KnowledgeBaseId { get; set; }

    public Guid? CaseId { get; set; }

    public Guid? StageId { get; set; }

    public virtual SysSchema? Case { get; set; }

    public virtual SysLanguage? Culture { get; set; }

    public virtual KnowledgeBase? KnowledgeBase { get; set; }
}
