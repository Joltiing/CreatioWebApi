using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class IntegrationLog
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? IntegrationSystemId { get; set; }

    public int SessionNumber { get; set; }

    public DateTime? Date { get; set; }

    public Guid? DirectionId { get; set; }

    public Guid? OperationId { get; set; }

    public Guid? ResultId { get; set; }

    public string Description { get; set; } = null!;

    public string ErrorDescription { get; set; } = null!;

    public virtual IntegrationDirection? Direction { get; set; }

    public virtual IntegrationSystem? IntegrationSystem { get; set; }

    public virtual IntegrationOperation? Operation { get; set; }

    public virtual IntegrationResult? Result { get; set; }
}
