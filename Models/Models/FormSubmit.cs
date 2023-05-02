using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FormSubmit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ContactId { get; set; }

    public string FormData { get; set; } = null!;

    public Guid? WebFormId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string CountryStr { get; set; } = null!;

    public Guid? CountryId { get; set; }

    public string AccountIndustryStr { get; set; } = null!;

    public Guid? AccountIndustryId { get; set; }

    public string JobTitle { get; set; } = null!;

    public string ContactDecisionRoleStr { get; set; } = null!;

    public Guid? ContactDecisionRoleId { get; set; }

    public string WorkEmail { get; set; } = null!;

    public string AccountEmployeesNumberStr { get; set; } = null!;

    public Guid? AccountEmployeesNumberId { get; set; }

    public string Account { get; set; } = null!;

    public string Website { get; set; } = null!;

    public Guid? GenderId { get; set; }

    public Guid? TimeZoneId { get; set; }

    public Guid? TerritoryId { get; set; }

    public string CityStr { get; set; } = null!;

    public Guid? CityId { get; set; }

    public DateTime? BirthDate { get; set; }

    public string Password { get; set; } = null!;

    public string LinkedInProfileUrl { get; set; } = null!;

    public Guid? RegisterMethodId { get; set; }

    public string Notes { get; set; } = null!;

    public Guid? SourceId { get; set; }

    public Guid? ChannelId { get; set; }

    public string UtmCampaignStr { get; set; } = null!;

    public string UtmMediumStr { get; set; } = null!;

    public string UtmSourceStr { get; set; } = null!;

    public string Referrer { get; set; } = null!;

    public Guid? WebFormDataId { get; set; }

    public virtual AccountEmployeesNumber? AccountEmployeesNumber { get; set; }

    public virtual AccountIndustry? AccountIndustry { get; set; }

    public virtual LeadMedium? Channel { get; set; }

    public virtual City? City { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual ContactDecisionRole? ContactDecisionRole { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual RegisterMethod? RegisterMethod { get; set; }

    public virtual LeadSource? Source { get; set; }

    public virtual Territory? Territory { get; set; }

    public virtual TimeZone? TimeZone { get; set; }

    public virtual GeneratedWebForm? WebForm { get; set; }

    public virtual WebFormDatum? WebFormData { get; set; }
}
