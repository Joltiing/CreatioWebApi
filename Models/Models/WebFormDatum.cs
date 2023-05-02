using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WebFormDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ContactId { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string Data { get; set; } = null!;

    public Guid? WebFormId { get; set; }

    public bool IsObjectCreated { get; set; }

    public string FullName { get; set; } = null!;

    public virtual Contact? Contact { get; set; }

    public virtual ICollection<FormSubmit> FormSubmits { get; set; } = new List<FormSubmit>();

    public virtual GeneratedWebForm? WebForm { get; set; }
}
