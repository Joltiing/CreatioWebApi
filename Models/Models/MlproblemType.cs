using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MlproblemType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string ServiceUrl { get; set; } = null!;

    public string TrainingEndpoint { get; set; } = null!;

    public string PredictionEndpoint { get; set; } = null!;

    public virtual ICollection<Mlmodel> Mlmodels { get; set; } = new List<Mlmodel>();

    public virtual ICollection<SysMlproblemTypeLcz> SysMlproblemTypeLczs { get; set; } = new List<SysMlproblemTypeLcz>();
}
