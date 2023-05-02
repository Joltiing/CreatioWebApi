using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLanguage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public bool IsUsed { get; set; }

    public virtual ICollection<Channel> Channels { get; set; } = new List<Channel>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<EmailTemplateLang> EmailTemplateLangs { get; set; } = new List<EmailTemplateLang>();

    public virtual ICollection<Playbook> Playbooks { get; set; } = new List<Playbook>();

    public virtual ICollection<SysAdminUnit> SysAdminUnits { get; set; } = new List<SysAdminUnit>();

    public virtual ICollection<SysCulture> SysCultures { get; set; } = new List<SysCulture>();

    public virtual ICollection<SysLanguageLcz> SysLanguageLczs { get; set; } = new List<SysLanguageLcz>();

    public virtual ICollection<Touch> Touches { get; set; } = new List<Touch>();
}
