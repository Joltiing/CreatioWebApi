using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EnrchTextEntity
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EnrchEmailDataId { get; set; }

    public string Type { get; set; } = null!;

    public string JsonData { get; set; } = null!;

    public string Hash { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public string DuplicationStatus { get; set; } = null!;

    public string Source { get; set; } = null!;

    public int HashVersion { get; set; }

    public virtual EnrchEmailDatum? EnrchEmailData { get; set; }

    public virtual ICollection<EnrchFoundAccount> EnrchFoundAccounts { get; set; } = new List<EnrchFoundAccount>();

    public virtual ICollection<EnrchFoundContact> EnrchFoundContacts { get; set; } = new List<EnrchFoundContact>();

    public virtual ICollection<EnrchTextEntity> InverseParent { get; set; } = new List<EnrchTextEntity>();

    public virtual EnrchTextEntity? Parent { get; set; }
}
