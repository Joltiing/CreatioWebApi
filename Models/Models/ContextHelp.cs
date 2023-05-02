using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContextHelp
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public int ContextHelpId { get; set; }

    public string Lmsurl { get; set; } = null!;

    public string ProductEdition { get; set; } = null!;

    public string ConfigurationVersion { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<SysContextHelpLcz> SysContextHelpLczs { get; set; } = new List<SysContextHelpLcz>();
}
