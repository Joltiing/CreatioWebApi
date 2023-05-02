using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FileImportParameter
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public byte[]? ImportParameters { get; set; }

    public byte[]? ImportEntities { get; set; }

    public int Stage { get; set; }

    public byte[]? FileData { get; set; }

    public int Size { get; set; }

    public virtual ICollection<ImportSessionChunk> ImportSessionChunks { get; set; } = new List<ImportSessionChunk>();
}
