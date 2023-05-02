using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Oauth20AppTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Oauth20AppInTag> Oauth20AppInTags { get; set; } = new List<Oauth20AppInTag>();

    public virtual ICollection<SysOauth20AppTagRight> SysOauth20AppTagRights { get; set; } = new List<SysOauth20AppTagRight>();

    public virtual TagType? Type { get; set; }
}
