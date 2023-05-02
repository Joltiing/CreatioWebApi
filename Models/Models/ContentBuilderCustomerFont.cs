using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContentBuilderCustomerFont
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? SysEntitySchemaUid { get; set; }

    public Guid? SysPageSchemaUid { get; set; }

    public Guid? SysLookupId { get; set; }

    public string Url { get; set; } = null!;
}
