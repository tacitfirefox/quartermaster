namespace Quartermaster.Core.Schema;

/// <summary>
/// Defines the make-up of a single crafting component item required to make or upgrade equipment items that the quartermaster knows about.
/// </summary>
public interface IComponentItem
{
    /// <summary>
    /// Gets the name of this component item.
    /// </summary>
    public string Name { get; }
}
