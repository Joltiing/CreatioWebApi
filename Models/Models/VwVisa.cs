using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwVisa
{
    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string ModifiedById { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string Objective { get; set; } = null!;

    public string VisaOwnerId { get; set; } = null!;

    public int IsAllowedToDelegate { get; set; }

    public string DelegatedFromId { get; set; } = null!;

    public string StatusId { get; set; } = null!;

    public string SetById { get; set; } = null!;

    public DateTime SetDate { get; set; }

    public int IsCanceled { get; set; }

    public string Comment { get; set; } = null!;

    public string VisaSchemaName { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string VisaObjectId { get; set; } = null!;

    public string VisaSchemaTypeId { get; set; } = null!;

    public string VisaTypeName { get; set; } = null!;

    public string VisaSchemaCaption { get; set; } = null!;
}
