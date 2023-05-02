using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LinkPreviewDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EntityId { get; set; }

    public byte[]? Data { get; set; }

    public string Url { get; set; } = null!;
}
