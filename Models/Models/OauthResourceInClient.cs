using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OauthResourceInClient
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? OauthResourceId { get; set; }

    public Guid? OauthClientId { get; set; }

    public virtual OauthClientApp? OauthClient { get; set; }

    public virtual OauthResource? OauthResource { get; set; }
}
