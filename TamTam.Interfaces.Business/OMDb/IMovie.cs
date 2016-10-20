using TamTam.Models.OMDb;
using TamTam.Models.OMDb.Search;
using System.Threading.Tasks;
using TamTam.Models.OMDb.Result;

namespace TamTam.Interfaces.Business.OMDb
{
    /// <summary>
    /// Interface for IMovie
    /// </summary>
    public interface IMovie
    {
        Task<Movie> GetMovieAsync(ParameterByIdOrTitle parametersByIdOrTitle);
    }
}
