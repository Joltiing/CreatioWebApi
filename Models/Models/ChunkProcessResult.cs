using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ChunkProcessResult
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ImportSessionChunkId { get; set; }

    public int RowIndex { get; set; }

    public bool Success { get; set; }

    public virtual ImportSessionChunk? ImportSessionChunk { get; set; }
}
