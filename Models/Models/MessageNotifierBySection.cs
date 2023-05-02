using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MessageNotifierBySection
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SectionId { get; set; }

    public Guid? MessageNotifierId { get; set; }

    public virtual MessageNotifier? MessageNotifier { get; set; }

    public virtual SysModule? Section { get; set; }
}
