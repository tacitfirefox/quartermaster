namespace Quartermaster.Implementation.Rin;

using Quartermaster.Core;

public class RinQuartermasterRegistration : IQuartermasterRegistration
{
    private readonly Guid _quartermasterId;

    public string Name => $"Rin's Travel Agency-Id {_quartermasterId}";

    public string Key => _quartermasterId.ToString();
}
