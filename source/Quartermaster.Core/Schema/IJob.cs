namespace Quartermaster.Core.Schema;

/// <summary>
/// Defines the make-up of a job.
/// </summary>
public interface IJob
{
    /// <summary>
    /// Gets the name of this job.
    /// </summary>
    public string Name { get; }
}
