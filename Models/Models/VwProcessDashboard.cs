using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwProcessDashboard
{
    public Guid? Id { get; set; }

    public Guid? ProcessElementEntityId { get; set; }

    public Guid? ProcessElementEntitySchemaUid { get; set; }

    public Guid ProcessElementId { get; set; }

    public Guid? ProcessDataId { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ProcessElementSchemaUid { get; set; }

    public Guid? ProcessSchemaElementUid { get; set; }

    public string ProcessName { get; set; } = null!;

    public Guid? ProcessOwnerId { get; set; }

    public Guid? ElementOwnerId { get; set; }

    public Guid? OwnerId { get; set; }

    public string ElementCaption { get; set; } = null!;

    public Guid? EntitySchemaUid { get; set; }

    public Guid? EntityId { get; set; }
}
