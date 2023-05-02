using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleVisa
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public bool UseCustomNotificationProvider { get; set; }

    public Guid? VisaSchemaUid { get; set; }

    public Guid? MasterColumnUid { get; set; }

    public virtual ICollection<PortalSysModule> PortalSysModules { get; set; } = new List<PortalSysModule>();

    public virtual ICollection<SysModule> SysModules { get; set; } = new List<SysModule>();
}
