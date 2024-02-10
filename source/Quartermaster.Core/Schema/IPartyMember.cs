namespace Quartermaster.Core.Schema;

using System.Collections.Generic;

/// <summary>
/// Defines the make-up of a party member.
/// </summary>
public interface IPartyMember
{
    /// <summary>
    /// Gets the name of this party member.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the jobs assigned to this party member.
    /// </summary>
    public IEnumerable<IJob>? Jobs { get; }

    /// <summary>
    /// Gets the equipment loadouts this party member is tracking.
    /// </summary>
    public IEnumerable<IEquipmentLoadout> Loadouts { get; }

    /// <summary>
    /// Add a new, empty loadout to this party member's collection of tracked equipment loadouts.
    /// </summary>
    public void AddEmptyLoadout();

    /// <summary>
    /// Removes the given loadout from this party member's tracked collection.
    /// </summary>
    /// <param name="loadoutToRemove">A loadout to remove from this party member's tracked loadouts.</param>
    public void RemoveLoadout(IEquipmentLoadout loadoutToRemove);

    /// <summary>
    /// Assign the party member the given job.
    /// </summary>
    /// <param name="job">A job to assign to the party member.</param>
    public void AssignJob(IJob job);

    /// <summary>
    /// Removes the assigned job from this party member.
    /// </summary>
    /// <param name="job">A job to unassign from this party member.</param>
    public void UnassignJob(IJob job);
}
