using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSettingsRight
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string SysSettingsCode { get; set; } = null!;

    public string ReadOperationCode { get; set; } = null!;

    public string ReadWriteOperationCode { get; set; } = null!;

    public int ProcessListeners { get; set; }
}
