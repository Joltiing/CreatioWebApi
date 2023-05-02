using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Touch
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? CityId { get; set; }

    public string PageReferrer { get; set; } = null!;

    public int Duration { get; set; }

    public string Domain { get; set; } = null!;

    public Guid? LanguageId { get; set; }

    public string Ip { get; set; } = null!;

    public Guid? CountryId { get; set; }

    public Guid? ContactId { get; set; }

    public string UtmTermStr { get; set; } = null!;

    public string UtmSourceStr { get; set; } = null!;

    public string UtmMediumStr { get; set; } = null!;

    public string UtmContentStr { get; set; } = null!;

    public string UtmCampaignStr { get; set; } = null!;

    public Guid? PlatformId { get; set; }

    public Guid? DeviceId { get; set; }

    public string SessionId { get; set; } = null!;

    public string PlatformStr { get; set; } = null!;

    public string LanguageStr { get; set; } = null!;

    public string DeviceStr { get; set; } = null!;

    public string CountryStr { get; set; } = null!;

    public string CityStr { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public string CountryCode { get; set; } = null!;

    public string RegionCode { get; set; } = null!;

    public string RegionStr { get; set; } = null!;

    public Guid? RegionId { get; set; }

    public string Location { get; set; } = null!;

    public string ReferrerTypeStr { get; set; } = null!;

    public string ReferrerNameStr { get; set; } = null!;

    public string ReferrerKeyword { get; set; } = null!;

    public string ReferrerUrl { get; set; } = null!;

    public Guid? ReferrerTypeId { get; set; }

    public Guid? ReferrerNameId { get; set; }

    public string UtmIdStr { get; set; } = null!;

    public Guid? SourceId { get; set; }

    public Guid? ChannelId { get; set; }

    public virtual LeadMedium? Channel { get; set; }

    public virtual City? City { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual Country? Country { get; set; }

    public virtual TouchDevice? Device { get; set; }

    public virtual SysLanguage? Language { get; set; }

    public virtual TouchPlatform? Platform { get; set; }

    public virtual ReferrerName? ReferrerName { get; set; }

    public virtual ReferrerType? ReferrerType { get; set; }

    public virtual Region? Region { get; set; }

    public virtual LeadSource? Source { get; set; }

    public virtual ICollection<TouchAction> TouchActions { get; set; } = new List<TouchAction>();
}
