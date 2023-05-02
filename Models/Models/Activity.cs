using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Activity
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public Guid? PriorityId { get; set; }

    public Guid? AuthorId { get; set; }

    public bool RemindToAuthor { get; set; }

    public DateTime? RemindToAuthorDate { get; set; }

    public Guid? OwnerId { get; set; }

    public bool RemindToOwner { get; set; }

    public DateTime? RemindToOwnerDate { get; set; }

    public Guid? TypeId { get; set; }

    public Guid? ActivityCategoryId { get; set; }

    public bool ShowInScheduler { get; set; }

    public Guid? StatusId { get; set; }

    public Guid? ResultId { get; set; }

    public string DetailedResult { get; set; } = null!;

    public Guid? TimeZoneId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? ContactId { get; set; }

    public string Sender { get; set; } = null!;

    public string Recepient { get; set; } = null!;

    public string CopyRecepient { get; set; } = null!;

    public string BlindCopyRecepient { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string Color { get; set; } = null!;

    public DateTime? SendDate { get; set; }

    public Guid? EmailSendStatusId { get; set; }

    public int DurationInMinutes { get; set; }

    public string ErrorOnSend { get; set; } = null!;

    public string DurationInMnutesAndHours { get; set; } = null!;

    public string AllowedResult { get; set; } = null!;

    public bool CreatedByInvCrm { get; set; }

    public Guid? MessageTypeId { get; set; }

    public int ProcessListeners { get; set; }

    public bool IsHtmlBody { get; set; }

    public string MailHash { get; set; } = null!;

    public Guid? ProcessElementId { get; set; }

    public string GlobalActivityId { get; set; } = null!;

    public bool IsNeedProcess { get; set; }

    public Guid? ActivityConnectionId { get; set; }

    public Guid? OrganizerId { get; set; }

    public Guid? CallDirectionId { get; set; }

    public string HeaderProperties { get; set; } = null!;

    public bool IsAutoSubmitted { get; set; }

    public Guid? SenderContactId { get; set; }

    public string Preview { get; set; } = null!;

    public Guid? EnrchEmailDataId { get; set; }

    public string EnrichStatus { get; set; } = null!;

    public string UserEmailAddress { get; set; } = null!;

    public string Location { get; set; } = null!;

    public Guid? OmniChatId { get; set; }

    public Guid? OwnerRoleId { get; set; }

    public DateTime? RemoteCreatedOn { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ActivityCategory? ActivityCategory { get; set; }

    public virtual Activity? ActivityConnection { get; set; }

    public virtual ICollection<ActivityFile> ActivityFiles { get; set; } = new List<ActivityFile>();

    public virtual ICollection<ActivityInFolder> ActivityInFolders { get; set; } = new List<ActivityInFolder>();

    public virtual ICollection<ActivityInTag> ActivityInTags { get; set; } = new List<ActivityInTag>();

    public virtual ICollection<ActivityParticipant> ActivityParticipants { get; set; } = new List<ActivityParticipant>();

    public virtual Contact? Author { get; set; }

    public virtual CallDirection? CallDirection { get; set; }

    public virtual ICollection<Call> Calls { get; set; } = new List<Call>();

    public virtual Contact? Contact { get; set; }

    public virtual ICollection<EmailMessageDatum> EmailMessageData { get; set; } = new List<EmailMessageDatum>();

    public virtual ICollection<EmailRelation> EmailRelations { get; set; } = new List<EmailRelation>();

    public virtual EmailSendStatus? EmailSendStatus { get; set; }

    public virtual ICollection<EmailTemplateActivity> EmailTemplateActivities { get; set; } = new List<EmailTemplateActivity>();

    public virtual EnrchEmailDatum? EnrchEmailData { get; set; }

    public virtual ICollection<Activity> InverseActivityConnection { get; set; } = new List<Activity>();

    public virtual EmailType? MessageType { get; set; }

    public virtual OmniChat? OmniChat { get; set; }

    public virtual Contact? Organizer { get; set; }

    public virtual Contact? Owner { get; set; }

    public virtual ActivityPriority? Priority { get; set; }

    public virtual ActivityResult? Result { get; set; }

    public virtual Contact? SenderContact { get; set; }

    public virtual ActivityStatus? Status { get; set; }

    public virtual ICollection<SysActivityRight> SysActivityRights { get; set; } = new List<SysActivityRight>();

    public virtual TimeZone? TimeZone { get; set; }

    public virtual ActivityType? Type { get; set; }
}
