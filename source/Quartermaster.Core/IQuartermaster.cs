namespace Quartermaster.Core;

using System.Collections.Generic;
using System.Threading.Tasks;
using Quartermaster.Core.Schema;

public interface IQuartermaster
{
    /// <summary>
    /// Gets this quartermaster's registration information.
    /// </summary>
    /// <returns>The registration information for this quartermaster.</returns>
    public Task<IQuartermasterRegistration> GetQuartermasterRegistrationAsync();

    /// <summary>
    /// Produces a receipt of component items and quantities to create all equipped items in all equipment sets of all party members in the given rosters.
    /// </summary>
    /// <param name="rostersToCheckout">A collection of rosters to checkout.</param>
    /// <returns>A receipt of component items and quantities.</returns>
    public Task<IQuartermasterReceipt> CheckoutRostersAsync(IEnumerable<IRoster> rostersToCheckout);
}