namespace Quartermaster.Core;

/// <summary>
/// Defines the required registration information a quartermaster must provide upon request.
/// </summary>
public interface IQuartermasterRegistration
{
    /// <summary>
    /// Gets a human-readable identifier for this quartermaster.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets a unique key value identifier for this quartermaster.
    /// </summary>
    public string Key { get; }
}
