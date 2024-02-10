namespace Quartermaster.Core.Schema;

using System.Collections.Generic;

/// <summary>
/// Defines the make-up of a single loadout of equipment for a party member.
/// </summary>
public interface IEquipmentLoadout
{
    /// <summary>
    /// Gets the name of loadout.
    /// </summary>
    public string? Name { get; }

    /// <summary>
    /// Sets the name of this equipment loadout to the one given.
    /// </summary>
    /// <param name="loadoutName">A name for the loadout.</param>
    public void SetName(string loadoutName);

    /// <summary>
    /// Gets the 
    /// </summary>
    public IEnumerable<IEquipmentSlot> EquipmentSlots { get; }
}
