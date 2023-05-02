using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class KnowledgeBase
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Keywords { get; set; } = null!;

    public Guid? TypeId { get; set; }

    public int ProcessListeners { get; set; }

    public int ViewsCount { get; set; }

    public string NotHtmlNote { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual ICollection<KnowledgeBaseFile> KnowledgeBaseFiles { get; set; } = new List<KnowledgeBaseFile>();

    public virtual ICollection<KnowledgeBaseInFolder> KnowledgeBaseInFolders { get; set; } = new List<KnowledgeBaseInFolder>();

    public virtual ICollection<KnowledgeBaseInTagV2> KnowledgeBaseInTagV2s { get; set; } = new List<KnowledgeBaseInTagV2>();

    public virtual ICollection<KnowledgeBaseTagDecoupling> KnowledgeBaseTagDecouplings { get; set; } = new List<KnowledgeBaseTagDecoupling>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Playbook> Playbooks { get; set; } = new List<Playbook>();

    public virtual ICollection<SysKnowledgeBaseRight> SysKnowledgeBaseRights { get; set; } = new List<SysKnowledgeBaseRight>();

    public virtual KnowledgeBaseType? Type { get; set; }
}
