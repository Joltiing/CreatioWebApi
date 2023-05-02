using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MessagePublisherBySection
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SectionId { get; set; }

    public Guid? MessagePublisherId { get; set; }

    public virtual MessagePublisher? MessagePublisher { get; set; }

    public virtual SysModule? Section { get; set; }
}
