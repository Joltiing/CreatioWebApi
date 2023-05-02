using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSchemaFavorite
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysSchemaId { get; set; }

    public Guid? SysAdminUnitId { get; set; }
}
