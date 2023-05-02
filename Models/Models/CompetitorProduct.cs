using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class CompetitorProduct
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? CompetitorId { get; set; }

    public string Name { get; set; } = null!;

    public string Weakness { get; set; } = null!;

    public string Strengths { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual Account? Competitor { get; set; }

    public virtual ICollection<SysCompetitorProductLcz> SysCompetitorProductLczs { get; set; } = new List<SysCompetitorProductLcz>();
}
