using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSettingsValue
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysSettingsId { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public bool IsDef { get; set; }

    public string TextValue { get; set; } = null!;

    public int IntegerValue { get; set; }

    public decimal FloatValue { get; set; }

    public bool BooleanValue { get; set; }

    public DateTime? DateTimeValue { get; set; }

    public Guid? GuidValue { get; set; }

    public byte[]? BinaryValue { get; set; }

    public int Position { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }

    public virtual SysSetting? SysSettings { get; set; }
}
