using System.Threading.Tasks;
using TamTam.Models.TamTam;
using TamTam.Models.TamTam.Result;
using TamTam.Models.TamTam.Search;

namespace TamTam.Interfaces.Business.TamTam
{
    public interface IAggregatedObject
    {
        Task<AggregatedObject> GetAggregatedObjectAsync(Parameter parameter);
    }
}
