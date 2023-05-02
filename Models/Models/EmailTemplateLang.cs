using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailTemplateLang
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EmailTemplateId { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public Guid? LanguageId { get; set; }

    public bool IsHtmlBody { get; set; }

    public string TemplateConfig { get; set; } = null!;

    public virtual EmailTemplate? EmailTemplate { get; set; }

    public virtual SysLanguage? Language { get; set; }
}
