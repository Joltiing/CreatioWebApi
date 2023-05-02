using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwOauthAppUser
{
    public Guid Id { get; set; }

    public Guid? OauthAppId { get; set; }

    public string UserAppLogin { get; set; } = null!;

    public Guid? SysUserId { get; set; }

    public string AccessToken { get; set; } = null!;
}
