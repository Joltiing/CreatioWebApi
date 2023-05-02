using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ChartProperty
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? EntityId { get; set; }

    public Guid? ChartAggregationTypeId { get; set; }

    public byte[]? ChartEntityColumn { get; set; }

    public byte[]? GroupByField { get; set; }

    public string XaxisCaption { get; set; } = null!;

    public string YaxisCaption { get; set; } = null!;

    public byte[]? Filter { get; set; }

    public string OrderDirection { get; set; } = null!;

    public string OrderByChartPropertyColumn { get; set; } = null!;

    public byte[]? ModuleObjAccessField { get; set; }

    public string ChartSeriesKind { get; set; } = null!;

    public Guid? GroupByTypeDateTimeId { get; set; }

    public Guid? ModuleEntityId { get; set; }

    public virtual ChartAggregationType? ChartAggregationType { get; set; }

    public virtual GroupByTypeDateTime? GroupByTypeDateTime { get; set; }

    public virtual ICollection<SysChartPropertyLcz> SysChartPropertyLczs { get; set; } = new List<SysChartPropertyLcz>();
}
