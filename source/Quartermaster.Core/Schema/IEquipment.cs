namespace Quartermaster.Core.Schema;

using System.Collections.Generic;

/// <summary>
/// Defines the make-up of an equipment item.
/// </summary>
public interface IEquipment
{
    /// <summary>
    /// Gets the name of this equipment item.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the collection of restrictions on how this equipment item can be assigned.
    /// </summary>
    public IEnumerable<IRestriction> EquipRestrictions { get; }

    /// <summary>
    /// Gets the collection of component items and their number required to create/craft/customize this piece of equipment.
    /// </summary>
    public IEnumerable<(IComponentItem Component, uint Amount)> Components { get; }
}
