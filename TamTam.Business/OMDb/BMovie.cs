using System.Net.Http;
using System.Threading.Tasks;
using TamTam.Interfaces.Business.OMDb;
using TamTam.Models.OMDb.Search;
using TamTam.Models.OMDb.Result;
using TamTam.Models.OMDb.API;

namespace TamTam.Business.OMDb
{
    public class BMovie : IMovie
    {
        public async Task<Movie> GetMovieAsync(ParameterByIdOrTitle parametersByIdOrTitle)
        {
            using (var client = new HttpClient ())
            {
                var parameters = Utils.Url.BuildUrlParameters(parametersByIdOrTitle, true);
                var response = await client.GetStringAsync(string.Concat(Constants.OmdbApiUrl,parameters));
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Movie>(response);
            }
        }
    }
}
