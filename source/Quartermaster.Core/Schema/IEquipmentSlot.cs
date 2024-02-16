namespace Quartermaster.Core.Schema;

/// <summary>
/// Defines the make-up of a single slot of equipment available to a party member loadout.
/// </summary>
public interface IEquipmentSlot
{
    /// <summary>
    /// Gets the name of this equipment slot.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the equipment item assigned to this equipment slot, if any.
    /// </summary>
    public IEquipment? Assignation { get; }

    /// <summary>
    /// Assigns the given equipment item to this equipment slot.
    /// </summary>
    /// <param name="equipmentItem">The equipment item to assign to this equipmnent slot.</param>
    public void Assign(IEquipment equipmentItem);

    /// <summary>
    /// Removes the assigned equipment item (if any) from this equipment slot.
    /// </summary>
    public void Unassign();
}
