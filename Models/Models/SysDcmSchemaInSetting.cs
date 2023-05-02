using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysDcmSchemaInSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysDcmSettingsId { get; set; }

    public Guid? SysDcmSchemaUid { get; set; }

    public virtual SysDcmSetting? SysDcmSettings { get; set; }
}
