using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.Neto
{
    public interface ICategoryResponse: IApiResponse
    {
        IEnumerable<int> CategoryIDs { get; }
    }
}
