namespace Quartermaster.Core.Schema;

using System.Collections.Generic;

/// <summary>
/// Defines the make-up of a party of characters.
/// </summary>
public interface IRoster
{
    /// <summary>
    /// Gets the unique key value identifier for this roster.
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// Gets the collection of party member slots available to the party.
    /// </summary>
    IEnumerable<IRosterSlot> RosterSlots { get; }
}