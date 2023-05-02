using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SecurityToken
{
    public string Token { get; set; } = null!;

    public byte[]? Data { get; set; }

    public DateTime ExpireDate { get; set; }
}
