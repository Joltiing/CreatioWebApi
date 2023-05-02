using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class TagType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<AccountTag> AccountTags { get; set; } = new List<AccountTag>();

    public virtual ICollection<ActivityTag> ActivityTags { get; set; } = new List<ActivityTag>();

    public virtual ICollection<CallTag> CallTags { get; set; } = new List<CallTag>();

    public virtual ICollection<ContactTag> ContactTags { get; set; } = new List<ContactTag>();

    public virtual ICollection<ContentBlockTag> ContentBlockTags { get; set; } = new List<ContentBlockTag>();

    public virtual ICollection<DuplicatesRuleTag> DuplicatesRuleTags { get; set; } = new List<DuplicatesRuleTag>();

    public virtual ICollection<EmailTemplateTag> EmailTemplateTags { get; set; } = new List<EmailTemplateTag>();

    public virtual ICollection<EmployeeTag> EmployeeTags { get; set; } = new List<EmployeeTag>();

    public virtual ICollection<ExternalAccessTag> ExternalAccessTags { get; set; } = new List<ExternalAccessTag>();

    public virtual ICollection<GeneratedWebFormTag> GeneratedWebFormTags { get; set; } = new List<GeneratedWebFormTag>();

    public virtual ICollection<KnowledgeBaseTagV2> KnowledgeBaseTagV2s { get; set; } = new List<KnowledgeBaseTagV2>();

    public virtual ICollection<LookupTag> LookupTags { get; set; } = new List<LookupTag>();

    public virtual ICollection<MkpInstalledAppNewsTag> MkpInstalledAppNewsTags { get; set; } = new List<MkpInstalledAppNewsTag>();

    public virtual ICollection<MlmodelTag> MlmodelTags { get; set; } = new List<MlmodelTag>();

    public virtual ICollection<Oauth20AppTag> Oauth20AppTags { get; set; } = new List<Oauth20AppTag>();

    public virtual ICollection<OmniChatTag> OmniChatTags { get; set; } = new List<OmniChatTag>();

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    public virtual ICollection<SocialChannelTag> SocialChannelTags { get; set; } = new List<SocialChannelTag>();

    public virtual ICollection<SysTagTypeLcz> SysTagTypeLczs { get; set; } = new List<SysTagTypeLcz>();

    public virtual ICollection<SysTranslationTag> SysTranslationTags { get; set; } = new List<SysTranslationTag>();

    public virtual ICollection<WebServiceV2tag> WebServiceV2tags { get; set; } = new List<WebServiceV2tag>();

    public virtual ICollection<WsysAccountTag> WsysAccountTags { get; set; } = new List<WsysAccountTag>();
}
