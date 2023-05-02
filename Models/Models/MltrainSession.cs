using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MltrainSession
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? MlmodelId { get; set; }

    public Guid? StateId { get; set; }

    public bool InUse { get; set; }

    public string Error { get; set; } = null!;

    public DateTime? TrainedOn { get; set; }

    public int TrainSetSize { get; set; }

    public decimal InstanceMetric { get; set; }

    public int TrainingTimeMinutes { get; set; }

    public bool IgnoreMetricThreshold { get; set; }

    public string FeatureImportances { get; set; } = null!;

    public virtual Mlmodel? Mlmodel { get; set; }

    public virtual MlmodelState? State { get; set; }
}
