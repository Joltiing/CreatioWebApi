using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OauthResource
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public virtual ICollection<OauthResourceInClient> OauthResourceInClients { get; set; } = new List<OauthResourceInClient>();
}
