using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WhatsAppMsgSetting
{
    public Guid Id { get; set; }

    public string Token { get; set; } = null!;

    public string IntegrationPhone { get; set; } = null!;

    public string AppId { get; set; } = null!;
}
