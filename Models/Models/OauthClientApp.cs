using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OauthClientApp
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public string ClientSecret { get; set; } = null!;

    public string RedirectUrl { get; set; } = null!;

    public string ApplicationUrl { get; set; } = null!;

    public bool IsActive { get; set; }

    public Guid? SystemUserId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<OauthResourceInClient> OauthResourceInClients { get; set; } = new List<OauthResourceInClient>();

    public virtual SysAdminUnit? SystemUser { get; set; }
}
