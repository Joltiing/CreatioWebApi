using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Favorite
{
    public Guid Id { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? KnowledgeBaseId { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual KnowledgeBase? KnowledgeBase { get; set; }
}
