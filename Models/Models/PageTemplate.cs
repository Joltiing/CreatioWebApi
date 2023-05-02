using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class PageTemplate
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? PageSchemaUid { get; set; }

    public Guid? PreviewImageId { get; set; }

    public int Position { get; set; }

    public virtual SysImage? PreviewImage { get; set; }
}
