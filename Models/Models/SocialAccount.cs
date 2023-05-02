using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SocialAccount
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Notes { get; set; } = null!;

    public string Login { get; set; } = null!;

    public bool Public { get; set; }

    public string AccessToken { get; set; } = null!;

    public string AccessSecretToken { get; set; } = null!;

    public string ConsumerKey { get; set; } = null!;

    public Guid? TypeId { get; set; }

    public Guid? UserId { get; set; }

    public string SocialId { get; set; } = null!;

    public bool IsExpired { get; set; }

    public string Name { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<Contact> ContactFacebookAfda { get; set; } = new List<Contact>();

    public virtual ICollection<Contact> ContactLinkedInAfda { get; set; } = new List<Contact>();

    public virtual ICollection<Contact> ContactTwitterAfda { get; set; } = new List<Contact>();

    public virtual ICollection<SysSocialAccountLcz> SysSocialAccountLczs { get; set; } = new List<SysSocialAccountLcz>();

    public virtual CommunicationType? Type { get; set; }

    public virtual SysAdminUnit? User { get; set; }
}
