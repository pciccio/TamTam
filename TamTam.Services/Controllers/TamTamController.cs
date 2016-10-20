using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using DryIoc;
using TamTam.Interfaces.Business.TamTam;
using TamTam.Models.TamTam.Search;
using WebApi.OutputCache.V2;


namespace TamTam.Services.Controllers
{
    [EnableCors("*", "*", "get")]
    [RoutePrefix("movies")]
    public class TamTamController : ApiController
    {
        [CacheOutput(ClientTimeSpan = 100, ServerTimeSpan = 100)]
        [Route("getbytitle/{movieTitle}")]
        [HttpGet]
        public async Task<object> GetMovieByTitle(string movieTitle)
        {
            //Get  container
            var iaggregatedObject = DependencyConfig.Container.Resolve<IAggregatedObject>();


            var parameter = new Parameter
            {
                MovieTitle = movieTitle
            };

            var aggregatedObject = await iaggregatedObject.GetAggregatedObjectAsync(parameter);

            //check is object is null
            if (aggregatedObject == null)
            {
                return NotFound();
            }

            //Return  object if exists
            return Ok(aggregatedObject);
        }

        [CacheOutput(ClientTimeSpan = 100, ServerTimeSpan = 100)]
        [Route("getbytitleandyear/{movieTitle}/{year:int}")]
        [HttpGet]
        public async Task<object> GetMovieByTitleYear(string movieTitle, int year)
        {
            //Get  container
            var iaggregatedObject = DependencyConfig.Container.Resolve<IAggregatedObject>();


            var parameter = new Parameter
            {
                MovieTitle = movieTitle,
                ReleaseYear = new DateTime(year, 1, 1)
            };

            var aggregatedObject = await iaggregatedObject.GetAggregatedObjectAsync(parameter);

            //check is object is null
            if (aggregatedObject == null)
            {
                return NotFound();
            }

            //Return  object if exists
            return Ok(aggregatedObject);
        }
    }
}
