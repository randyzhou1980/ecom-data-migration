using System.Collections.Generic;

namespace DMEntity.Neto
{
    public interface ICustomerResponse: IApiResponse
    {
        IEnumerable<string> UserNames { get; }
    }
}
