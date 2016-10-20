using System.Net.Http;
using System.Threading.Tasks;
using TamTam.Business.OMDb;
using TamTam.Business.YouTube;
using TamTam.Interfaces.Business.TamTam;
using TamTam.Models.OMDb.Search;
using TamTam.Models.TamTam.Result;
using TamTam.Models.TamTam.Search;
using Enumerator = TamTam.Models.YouTube.Search.Enumerator;

namespace TamTam.Business.TamTam
{
    public class BAggregatedObject : IAggregatedObject
    {
        public async Task<AggregatedObject> GetAggregatedObjectAsync(Parameter parameter)
        {
            return await Task.Run(() =>
            {
                var omdbParametersByIdOrTitle = ComposeOmdbParametersByIdOrTitle(parameter);

                var m = new BMovie();
                var getMovieAsync = m.GetMovieAsync(omdbParametersByIdOrTitle);
                
                var youtubeParameters = ComposeYoutubeParameters(parameter);

                var b = new BVideo();
                var getVideoAsync = b.GetVideoAsync(youtubeParameters);


                var tasks = new Task[2];
                tasks[0] = getMovieAsync;
                tasks[1] = getVideoAsync;

                Task.WhenAll(tasks);

                return new AggregatedObject { Movie = getMovieAsync.Result, Video = getVideoAsync.Result };
            });
        }

        private static ParameterByIdOrTitle ComposeOmdbParametersByIdOrTitle(Parameter parameter)
        {
            var omdbParameterByIdOrTitle = new ParameterByIdOrTitle
            {
                MovieTitle = parameter.MovieTitle,
                ReleaseDate = parameter.ReleaseYear,
                Plot = Models.OMDb.Search.Enumerator.Plot.Full
            };
            return omdbParameterByIdOrTitle;
        }

        private static Models.YouTube.Search.Parameter ComposeYoutubeParameters(Parameter parameter)
        {
            var youtubeParameter = new Models.YouTube.Search.Parameter
            {
                q = parameter.MovieTitle,
                part = Enumerator.Part.Snippet,
                type = Enumerator.Type.Video,
                videoEmbeddable = Enumerator.VideoEmbeddable.True,
                videoDuration = Enumerator.VideoDuration.Short,
                maxResults = 1,
                videoCategoryId = "44"
            };
            return youtubeParameter;
        }
    }
}
