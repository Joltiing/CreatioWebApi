using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SocialMessage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public Guid? EntityId { get; set; }

    public string Message { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public int LikeCount { get; set; }

    public int CommentCount { get; set; }

    public DateTime? LastActionOn { get; set; }

    public virtual ICollection<Esnnotification> Esnnotifications { get; set; } = new List<Esnnotification>();

    public virtual ICollection<SocialMessage> InverseParent { get; set; } = new List<SocialMessage>();

    public virtual SocialMessage? Parent { get; set; }

    public virtual ICollection<SocialLike> SocialLikes { get; set; } = new List<SocialLike>();

    public virtual ICollection<SocialMention> SocialMentions { get; set; } = new List<SocialMention>();

    public virtual ICollection<SocialMessageEntity> SocialMessageEntities { get; set; } = new List<SocialMessageEntity>();
}
