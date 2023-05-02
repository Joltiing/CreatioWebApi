using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FacebookMsgSetting
{
    public Guid Id { get; set; }

    public string Token { get; set; } = null!;
}
