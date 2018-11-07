using System.Collections.Generic;

namespace DMEntity.Neto
{
    public interface IApiResponse
    {
        string Status { get; }
        IEnumerable<string> Errors { get; }
    }
}
