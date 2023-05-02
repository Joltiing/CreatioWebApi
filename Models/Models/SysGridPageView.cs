using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysGridPageView
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public Guid? SysGridPageId { get; set; }

    public string DataSourceFilterCode { get; set; } = null!;

    public int Position { get; set; }

    public Guid? SysStoringStateId { get; set; }

    public Guid? OwnerId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysGridPageView> InverseParent { get; set; } = new List<SysGridPageView>();

    public virtual Contact? Owner { get; set; }

    public virtual SysGridPageView? Parent { get; set; }

    public virtual SysGridPage? SysGridPage { get; set; }

    public virtual ICollection<SysGridPageViewLcz> SysGridPageViewLczs { get; set; } = new List<SysGridPageViewLcz>();

    public virtual SysStoringObjectState? SysStoringState { get; set; }
}
