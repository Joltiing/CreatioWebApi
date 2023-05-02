using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WebService
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? WebServiceUrlid { get; set; }

    public string Wsdlurl { get; set; } = null!;

    public string Wsdl { get; set; } = null!;

    public int Timeout { get; set; }

    public Guid? HttpauthTypeId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool GenerateProxy { get; set; }

    public string Namespace { get; set; } = null!;

    public virtual HttpauthType? HttpauthType { get; set; }

    public virtual ICollection<SysWebServiceLcz> SysWebServiceLczs { get; set; } = new List<SysWebServiceLcz>();

    public virtual WebServiceUrl? WebServiceUrl { get; set; }

    public virtual ICollection<WebServiceUrl> WebServiceUrls { get; set; } = new List<WebServiceUrl>();
}
