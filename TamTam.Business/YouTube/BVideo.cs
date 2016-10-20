using System.Net.Http;
using System.Threading.Tasks;
using TamTam.Interfaces.Business.YouTube;
using TamTam.Models.YouTube.Result;
using TamTam.Models.YouTube.Search;
using TamTam.Models.YouTube.API;

namespace TamTam.Business.YouTube
{
    public class BVideo : IVideo
    {
        public async Task<Result> GetVideoAsync(Parameter parameter)
        {
            using (var client = new HttpClient())
            {
                var parameters = Utils.Url.BuildUrlParameters(parameter);
                var response = await client.GetStringAsync(string.Concat(Constants.SearchApiUrl, parameters));
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Result>(response);
            }
        }
    }
}
