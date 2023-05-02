using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OauthApplication
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string AppClassName { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public string SecretKey { get; set; } = null!;

    public string ClientClassName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string AuthorizeUrl { get; set; } = null!;

    public string TokenUrl { get; set; } = null!;

    public string RevokeTokenUrl { get; set; } = null!;

    public bool UseSharedUser { get; set; }

    public Guid? SharedUserId { get; set; }

    public Guid? ImageId { get; set; }

    public int CredentialsLocationInRequest { get; set; }

    public int AccessType { get; set; }

    public virtual SysImage? Image { get; set; }

    public virtual ICollection<MailServer> MailServers { get; set; } = new List<MailServer>();

    public virtual ICollection<Oauth20AppFile> Oauth20AppFiles { get; set; } = new List<Oauth20AppFile>();

    public virtual ICollection<Oauth20AppInFolder> Oauth20AppInFolders { get; set; } = new List<Oauth20AppInFolder>();

    public virtual ICollection<Oauth20AppInTag> Oauth20AppInTags { get; set; } = new List<Oauth20AppInTag>();

    public virtual ICollection<OauthAppScope> OauthAppScopes { get; set; } = new List<OauthAppScope>();

    public virtual ICollection<OauthTokenStorage> OauthTokenStorages { get; set; } = new List<OauthTokenStorage>();

    public virtual SysAdminUnit? SharedUser { get; set; }
}
