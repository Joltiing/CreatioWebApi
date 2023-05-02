using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class TelegramMsgSetting
{
    public Guid Id { get; set; }

    public string Token { get; set; } = null!;

    public string UserName { get; set; } = null!;
}
