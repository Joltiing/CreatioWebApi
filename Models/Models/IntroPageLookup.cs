using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class IntroPageLookup
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string CodePage { get; set; } = null!;

    public string AcademyUrl { get; set; } = null!;

    public string VideoUrl { get; set; } = null!;

    public string VideoCaption { get; set; } = null!;

    public virtual ICollection<SysIntroPageLookupLcz> SysIntroPageLookupLczs { get; set; } = new List<SysIntroPageLookupLcz>();
}
