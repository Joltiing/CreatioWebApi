using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwPageTemplate
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

    public Guid SysSchemaId { get; set; }

    public string PageSchemaName { get; set; } = null!;

    public string SchemaCaption { get; set; } = null!;

    public string SchemaDescription { get; set; } = null!;
}
