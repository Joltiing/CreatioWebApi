using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailTemplate
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public Guid? ObjectId { get; set; }

    public byte[]? Recipient { get; set; }

    public byte[]? CopyRecipient { get; set; }

    public byte[]? BlindCopyRecipient { get; set; }

    public string Subject { get; set; } = null!;

    public Guid? PriorityId { get; set; }

    public string Body { get; set; } = null!;

    public bool IsHtmlBody { get; set; }

    public byte[]? Macros { get; set; }

    public Guid? SendIndividualEmailId { get; set; }

    public bool SaveAsActivity { get; set; }

    public Guid? ObjectFieldInActivity { get; set; }

    public bool ShowBeforeSending { get; set; }

    public string TemplateConfig { get; set; } = null!;

    public int ConfigType { get; set; }

    public Guid? PreviewImageId { get; set; }

    public string Notes { get; set; } = null!;

    public Guid? TemplateTypeId { get; set; }

    public virtual ICollection<EmailTemplateActivity> EmailTemplateActivities { get; set; } = new List<EmailTemplateActivity>();

    public virtual ICollection<EmailTemplateFile> EmailTemplateFiles { get; set; } = new List<EmailTemplateFile>();

    public virtual ICollection<EmailTemplateInFolder> EmailTemplateInFolders { get; set; } = new List<EmailTemplateInFolder>();

    public virtual ICollection<EmailTemplateInTag> EmailTemplateInTags { get; set; } = new List<EmailTemplateInTag>();

    public virtual ICollection<EmailTemplateLang> EmailTemplateLangs { get; set; } = new List<EmailTemplateLang>();

    public virtual SysImage? PreviewImage { get; set; }

    public virtual ActivityPriority? Priority { get; set; }

    public virtual EmailTemplateSendFlag? SendIndividualEmail { get; set; }

    public virtual ICollection<SocialFeedFavoriteTpl> SocialFeedFavoriteTpls { get; set; } = new List<SocialFeedFavoriteTpl>();

    public virtual ICollection<SysEmailTemplateLcz> SysEmailTemplateLczs { get; set; } = new List<SysEmailTemplateLcz>();

    public virtual MessageTemplateType? TemplateType { get; set; }
}
