using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactsProductInterest
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ProductId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? DateOfProposal { get; set; }

    public Guid? ResultOfProposalId { get; set; }

    public string Comments { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual Product? Product { get; set; }

    public virtual PropositionResult? ResultOfProposal { get; set; }
}
