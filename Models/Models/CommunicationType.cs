using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class CommunicationType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte[]? Image { get; set; }

    public string HyperlinkTemplate { get; set; } = null!;

    public bool UseforAccounts { get; set; }

    public bool UseforContacts { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<AccountCommunication> AccountCommunications { get; set; } = new List<AccountCommunication>();

    public virtual ICollection<ComTypebyCommunication> ComTypebyCommunications { get; set; } = new List<ComTypebyCommunication>();

    public virtual ICollection<ContactCommunication> ContactCommunications { get; set; } = new List<ContactCommunication>();

    public virtual ICollection<ContactCorrespondence> ContactCorrespondences { get; set; } = new List<ContactCorrespondence>();

    public virtual ICollection<CtisearchResult> CtisearchResults { get; set; } = new List<CtisearchResult>();

    public virtual ICollection<EmailTemplateMacro> EmailTemplateMacros { get; set; } = new List<EmailTemplateMacro>();

    public virtual ICollection<EnrchTypeMapping> EnrchTypeMappings { get; set; } = new List<EnrchTypeMapping>();

    public virtual ICollection<SocialAccount> SocialAccounts { get; set; } = new List<SocialAccount>();

    public virtual ICollection<SysCommunicationTypeLcz> SysCommunicationTypeLczs { get; set; } = new List<SysCommunicationTypeLcz>();
}
