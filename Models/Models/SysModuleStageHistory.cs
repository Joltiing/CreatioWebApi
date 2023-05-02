using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleStageHistory
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public Guid? StageSchemaUid { get; set; }

    public Guid? StageHistorySchemaUid { get; set; }

    public Guid? StageColUid { get; set; }

    public Guid? OwnerColUid { get; set; }

    public Guid? StageIsFinalColUid { get; set; }

    public Guid? StageIsSuccessfulColUid { get; set; }

    public Guid? StageOrderColUid { get; set; }

    public Guid? StageHistoryStartDateColUid { get; set; }

    public Guid? StageHistoryDueDateColUid { get; set; }

    public Guid? StageHistoryOwnerColUid { get; set; }

    public Guid? StageHistoryHistoricalColUid { get; set; }

    public Guid? StageHistoryMainEntityColUid { get; set; }

    public Guid? StageHistoryStageColUid { get; set; }

    public bool Active { get; set; }
}
