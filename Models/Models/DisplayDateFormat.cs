using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DisplayDateFormat
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Format { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysDisplayDateFormatRight> SysDisplayDateFormatRights { get; set; } = new List<SysDisplayDateFormatRight>();
}
