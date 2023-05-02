﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class KnowledgeBaseTagV2
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<KnowledgeBaseInTagV2> KnowledgeBaseInTagV2s { get; set; } = new List<KnowledgeBaseInTagV2>();

    public virtual ICollection<SysKnowledgeBaseTagV2right> SysKnowledgeBaseTagV2rights { get; set; } = new List<SysKnowledgeBaseTagV2right>();

    public virtual TagType? Type { get; set; }
}
