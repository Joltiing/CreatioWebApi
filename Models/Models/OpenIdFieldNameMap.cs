using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OpenIdFieldNameMap
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string EntityFieldName { get; set; } = null!;

    public string OpenIdClaimName { get; set; } = null!;
}
