namespace Quartermaster.Core;

using Quartermaster.Core.Schema;
using System;
using System.Collections.Generic;

public interface IQuartermasterReceipt
{
    /// <summary>
    /// Gets the identifier for this receipt recognized by the issuing quartermaster.
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// Gets the date and time the transaction was processed by the quartermaster.
    /// </summary>
    public DateTime TransactionTimestamp { get; }

    /// <summary>
    /// Gets a collection of component items and quantities for a collection of craftable equipment items checked out by the quartermaster during the transaction.
    /// </summary>
    public IEnumerable<(IComponentItem Item, uint Quantity)> LineItems { get; }
}
