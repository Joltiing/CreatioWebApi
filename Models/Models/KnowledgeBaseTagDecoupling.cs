using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class KnowledgeBaseTagDecoupling
{
    public Guid Id { get; set; }

    public Guid? TagId { get; set; }

    public Guid? KnowledgeBaseId { get; set; }

    public virtual KnowledgeBase? KnowledgeBase { get; set; }

    public virtual KnowledgeBaseTag? Tag { get; set; }
}
