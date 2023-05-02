using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwRecepientEmail
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public int UseEmail { get; set; }

    public Guid? ContactId { get; set; }

    public string Number { get; set; } = null!;

    public string ContactName { get; set; } = null!;
}
