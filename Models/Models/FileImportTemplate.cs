using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FileImportTemplate
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public byte[]? TemplateData { get; set; }

    public bool RecordInactive { get; set; }

    public virtual ICollection<SysFileImportTemplateLcz> SysFileImportTemplateLczs { get; set; } = new List<SysFileImportTemplateLcz>();
}
