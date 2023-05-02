using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwRecentCall
{
    public Guid Id { get; set; }

    public Guid CallId { get; set; }

    public Guid? CreatedById { get; set; }
}
