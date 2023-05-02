using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysProcessSchemaUserRight
{
    public Guid Id { get; set; }

    public Guid SysSchemaId { get; set; }

    public Guid SysAdminUnitId { get; set; }
}
