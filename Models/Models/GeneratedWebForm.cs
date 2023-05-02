using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class GeneratedWebForm
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ExternalUrl { get; set; } = null!;

    public string ReturnUrl { get; set; } = null!;

    public string EntityDefaultValues { get; set; } = null!;

    public string FormFields { get; set; } = null!;

    public string Body { get; set; } = null!;

    public Guid? StateId { get; set; }

    public string Notes { get; set; } = null!;

    public Guid? OwnerId { get; set; }

    public bool CreateContact { get; set; }

    public Guid? TypeId { get; set; }

    public Guid? IdentificationProcessId { get; set; }

    public virtual ICollection<FormSubmit> FormSubmits { get; set; } = new List<FormSubmit>();

    public virtual ICollection<GeneratedWebFormFile> GeneratedWebFormFiles { get; set; } = new List<GeneratedWebFormFile>();

    public virtual ICollection<GeneratedWebFormInFolder> GeneratedWebFormInFolders { get; set; } = new List<GeneratedWebFormInFolder>();

    public virtual ICollection<GeneratedWebFormInTag> GeneratedWebFormInTags { get; set; } = new List<GeneratedWebFormInTag>();

    public virtual WebFormContactIdentifier? IdentificationProcess { get; set; }

    public virtual ICollection<LandingObjectDefault> LandingObjectDefaults { get; set; } = new List<LandingObjectDefault>();

    public virtual Contact? Owner { get; set; }

    public virtual LendingState? State { get; set; }

    public virtual LandingType? Type { get; set; }

    public virtual ICollection<WebFormDatum> WebFormData { get; set; } = new List<WebFormDatum>();
}
