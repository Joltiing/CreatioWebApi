using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OauthAppScope
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Scope { get; set; } = null!;

    public Guid? Oauth20AppId { get; set; }

    public virtual OauthApplication? Oauth20App { get; set; }
}
