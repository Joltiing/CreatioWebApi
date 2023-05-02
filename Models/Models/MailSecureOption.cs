﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MailSecureOption
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<MailServer> MailServerImapSecureOptions { get; set; } = new List<MailServer>();

    public virtual ICollection<MailServer> MailServerSmtpSecureOptions { get; set; } = new List<MailServer>();
}
