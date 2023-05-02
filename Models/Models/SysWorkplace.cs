using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysWorkplace
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public int Position { get; set; }

    public string Name { get; set; } = null!;

    public bool IsPersonal { get; set; }

    public Guid? LoaderId { get; set; }

    public Guid? SysApplicationClientTypeId { get; set; }

    public Guid? TypeId { get; set; }

    public Guid? HomePageUid { get; set; }

    public virtual ICollection<SysAdminUnitInWorkplace> SysAdminUnitInWorkplaces { get; set; } = new List<SysAdminUnitInWorkplace>();

    public virtual SysApplicationClientType? SysApplicationClientType { get; set; }

    public virtual ICollection<SysModuleInWorkplace> SysModuleInWorkplaces { get; set; } = new List<SysModuleInWorkplace>();

    public virtual ICollection<SysWorkplaceLcz> SysWorkplaceLczs { get; set; } = new List<SysWorkplaceLcz>();

    public virtual SysWorkplaceType? Type { get; set; }
}
