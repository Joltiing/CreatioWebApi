using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ImportSessionChunk
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public int Type { get; set; }

    public int State { get; set; }

    public byte[]? Data { get; set; }

    public Guid? ImportParametersId { get; set; }

    public virtual ICollection<ChunkProcessResult> ChunkProcessResults { get; set; } = new List<ChunkProcessResult>();

    public virtual FileImportParameter? ImportParameters { get; set; }
}
