using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivitySyncSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? MailboxSyncSettingsId { get; set; }

    public DateTime? AppointmentLastSyncDate { get; set; }

    public DateTime? TaskLastSyncDate { get; set; }

    public bool ImportTasks { get; set; }

    public bool ImportTasksAll { get; set; }

    public string ImportTasksFolders { get; set; } = null!;

    public bool ImportTasksFromFolders { get; set; }

    public DateTime? ImportActivitiesFrom { get; set; }

    public bool ImportAppointments { get; set; }

    public bool ImportAppointmentsAll { get; set; }

    public bool ImpAppointmentsFromCalendars { get; set; }

    public string ImportAppointmentsCalendars { get; set; } = null!;

    public bool ExportActivities { get; set; }

    public bool ExportActivitiesAll { get; set; }

    public bool ExportActivitiesSelected { get; set; }

    public bool ExportAppointments { get; set; }

    public bool ExportTasks { get; set; }

    public bool ExportActivitiesFromScheduler { get; set; }

    public bool ExportActivitiesFromGroups { get; set; }

    public string ExportActivitiesGroups { get; set; } = null!;

    public Guid? ActivitySyncPeriodId { get; set; }

    public virtual MailSyncPeriod? ActivitySyncPeriod { get; set; }

    public virtual MailboxSyncSetting? MailboxSyncSettings { get; set; }
}
