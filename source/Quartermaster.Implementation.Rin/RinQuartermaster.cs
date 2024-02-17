namespace Quartermaster.Implementation.Rin;

using System.Collections.Generic;
using System.Threading.Tasks;
using Quartermaster.Core;
using Quartermaster.Core.Schema;

public class RinQuartermaster : IQuartermaster
{
    private readonly IQuartermasterRegistration _quartermasterRegistration = new RinQuartermasterRegistration();

    public Task<IQuartermasterReceipt> CheckoutRostersAsync(IEnumerable<IRoster> rostersToCheckout)
    {
        throw new NotImplementedException();
    }

    public Task<IQuartermasterRegistration> GetQuartermasterRegistrationAsync() => Task.FromResult(this._quartermasterRegistration);
}
