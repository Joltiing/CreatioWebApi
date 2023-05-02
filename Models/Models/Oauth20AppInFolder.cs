using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Oauth20AppInFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? FolderId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? Oauth20AppId { get; set; }

    public virtual Oauth20AppFolder? Folder { get; set; }

    public virtual OauthApplication? Oauth20App { get; set; }

    public virtual ICollection<SysOauth20AppInFolderRight> SysOauth20AppInFolderRights { get; set; } = new List<SysOauth20AppInFolderRight>();
}
