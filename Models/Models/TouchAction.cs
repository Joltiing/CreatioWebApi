using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class TouchAction
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TouchId { get; set; }

    public DateTime? ActionDate { get; set; }

    public string Title { get; set; } = null!;

    public string Url { get; set; } = null!;

    public Guid? TypeId { get; set; }

    public string ActionId { get; set; } = null!;

    public string TypeStr { get; set; } = null!;

    public Guid? WebPageId { get; set; }

    public virtual Touch? Touch { get; set; }

    public virtual TouchActionType? Type { get; set; }

    public virtual WebPage? WebPage { get; set; }
}
