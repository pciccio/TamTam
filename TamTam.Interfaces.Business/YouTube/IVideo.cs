using System.Threading.Tasks;
using TamTam.Models.YouTube.Result;
using TamTam.Models.YouTube.Search;

namespace TamTam.Interfaces.Business.YouTube
{
    /// <summary>
    /// Interface for IVdeo
    /// </summary>
    public interface IVideo
    {
        Task<Result> GetVideoAsync(Parameter parameter);
    }
}
