namespace Quartermaster.Core.Schema;

/// <summary>
/// Defines the make-up of a single place in the party.
/// </summary>
public interface IRosterSlot
{
    /// <summary>
    /// Gets the party member assigned to this roster slot, if any.
    /// </summary>
    IPartyMember? Assignation { get; }

    /// <summary>
    /// Assigns the given party member to this roster slot.
    /// </summary>
    /// <param name="member">The party member to assign to this slot.</param>
    public void Assign(IPartyMember member);

    /// <summary>
    /// Removes the assigned party member (if any) from this roster slot.
    /// </summary>
    public void Unassign();
}
