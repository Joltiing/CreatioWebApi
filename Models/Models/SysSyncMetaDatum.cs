using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSyncMetaDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string SyncSchemaName { get; set; } = null!;

    public string RemoteId { get; set; } = null!;

    public Guid? LocalId { get; set; }

    public Guid? RemoteStoreId { get; set; }

    public bool IsLocalDeleted { get; set; }

    public bool IsRemoteDeleted { get; set; }

    public Guid? ModifiedInStoreId { get; set; }

    public DateTime? Version { get; set; }

    public Guid? CreatedInStoreId { get; set; }

    public string RemoteItemName { get; set; } = null!;

    public int SchemaOrder { get; set; }

    public string ExtraParameters { get; set; } = null!;

    public int LocalState { get; set; }

    public int RemoteState { get; set; }

    public int ProcessListeners { get; set; }
}
