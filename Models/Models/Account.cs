using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Account
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? OwnerId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? OwnershipId { get; set; }

    public Guid? PrimaryContactId { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? IndustryId { get; set; }

    public string Code { get; set; } = null!;

    public Guid? TypeId { get; set; }

    public string Phone { get; set; } = null!;

    public string AdditionalPhone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Web { get; set; } = null!;

    public Guid? AddressTypeId { get; set; }

    public string Address { get; set; } = null!;

    public Guid? CityId { get; set; }

    public Guid? RegionId { get; set; }

    public string Zip { get; set; } = null!;

    public Guid? CountryId { get; set; }

    public Guid? AccountCategoryId { get; set; }

    public Guid? EmployeesNumberId { get; set; }

    public Guid? AnnualRevenueId { get; set; }

    public string Notes { get; set; } = null!;

    public byte[]? Logo { get; set; }

    public string AlternativeName { get; set; } = null!;

    public string Gpsn { get; set; } = null!;

    public string Gpse { get; set; } = null!;

    public Guid? AccountLogoId { get; set; }

    public int Completeness { get; set; }

    public string Aum { get; set; } = null!;

    public virtual ICollection<AccountAddress> AccountAddresses { get; set; } = new List<AccountAddress>();

    public virtual ICollection<AccountAlternativeName> AccountAlternativeNames { get; set; } = new List<AccountAlternativeName>();

    public virtual ICollection<AccountAnniversary> AccountAnniversaries { get; set; } = new List<AccountAnniversary>();

    public virtual ICollection<AccountBillingInfo> AccountBillingInfos { get; set; } = new List<AccountBillingInfo>();

    public virtual AccountCategory? AccountCategory { get; set; }

    public virtual ICollection<AccountCommunication> AccountCommunications { get; set; } = new List<AccountCommunication>();

    public virtual ICollection<AccountDuplicate> AccountDuplicateEntity1s { get; set; } = new List<AccountDuplicate>();

    public virtual ICollection<AccountDuplicate> AccountDuplicateEntity2s { get; set; } = new List<AccountDuplicate>();

    public virtual ICollection<AccountEnrichedDatum> AccountEnrichedData { get; set; } = new List<AccountEnrichedDatum>();

    public virtual ICollection<AccountFile> AccountFiles { get; set; } = new List<AccountFile>();

    public virtual ICollection<AccountInFolder> AccountInFolders { get; set; } = new List<AccountInFolder>();

    public virtual ICollection<AccountInTag> AccountInTags { get; set; } = new List<AccountInTag>();

    public virtual SysImage? AccountLogo { get; set; }

    public virtual ICollection<AccountOrganizationChart> AccountOrganizationCharts { get; set; } = new List<AccountOrganizationChart>();

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual AddressType? AddressType { get; set; }

    public virtual AccountAnnualRevenue? AnnualRevenue { get; set; }

    public virtual ICollection<Call> Calls { get; set; } = new List<Call>();

    public virtual City? City { get; set; }

    public virtual ICollection<CompetitorProduct> CompetitorProducts { get; set; } = new List<CompetitorProduct>();

    public virtual ICollection<ContactCareer> ContactCareers { get; set; } = new List<ContactCareer>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<CtisearchResult> CtisearchResults { get; set; } = new List<CtisearchResult>();

    public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettings { get; set; } = new List<EmailFolderColumnValuesSetting>();

    public virtual ICollection<EmployeeCareer> EmployeeCareers { get; set; } = new List<EmployeeCareer>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual AccountEmployeesNumber? EmployeesNumber { get; set; }

    public virtual ICollection<EnrchFoundAccount> EnrchFoundAccounts { get; set; } = new List<EnrchFoundAccount>();

    public virtual AccountIndustry? Industry { get; set; }

    public virtual ICollection<Account> InverseParent { get; set; } = new List<Account>();

    public virtual Contact? Owner { get; set; }

    public virtual AccountOwnership? Ownership { get; set; }

    public virtual Account? Parent { get; set; }

    public virtual Contact? PrimaryContact { get; set; }

    public virtual ICollection<QuickDialUserSetting> QuickDialUserSettings { get; set; } = new List<QuickDialUserSetting>();

    public virtual Region? Region { get; set; }

    public virtual ICollection<Relationship> RelationshipAccountAs { get; set; } = new List<Relationship>();

    public virtual ICollection<Relationship> RelationshipAccountBs { get; set; } = new List<Relationship>();

    public virtual ICollection<SysAccountRight> SysAccountRights { get; set; } = new List<SysAccountRight>();

    public virtual ICollection<SysAdminUnit> SysAdminUnitAccounts { get; set; } = new List<SysAdminUnit>();

    public virtual ICollection<SysAdminUnit> SysAdminUnitPortalAccounts { get; set; } = new List<SysAdminUnit>();

    public virtual AccountType? Type { get; set; }
}
