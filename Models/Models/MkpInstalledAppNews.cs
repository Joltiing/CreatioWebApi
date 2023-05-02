using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MkpInstalledAppNews
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string MkpNotes { get; set; } = null!;

    public virtual ICollection<MkpInstalledAppNewsFile> MkpInstalledAppNewsFiles { get; set; } = new List<MkpInstalledAppNewsFile>();

    public virtual ICollection<MkpInstalledAppNewsInFolder> MkpInstalledAppNewsInFolders { get; set; } = new List<MkpInstalledAppNewsInFolder>();

    public virtual ICollection<MkpInstalledAppNewsInTag> MkpInstalledAppNewsInTags { get; set; } = new List<MkpInstalledAppNewsInTag>();
}
