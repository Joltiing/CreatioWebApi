using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysIntroPageLookupLcz
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysCultureId { get; set; }

    public string? AcademyUrl { get; set; }

    public string? VideoUrl { get; set; }

    public string? VideoCaption { get; set; }

    public virtual IntroPageLookup? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
