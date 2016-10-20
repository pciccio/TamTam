using Newtonsoft.Json;

namespace TamTam.Models.OMDb.Search
{
    public class ParameterByIdOrTitle : ParameterBase
    {
        /// <summary>
        /// A valid IMDb ID (e.g. tt1285016)
        /// </summary>
        [JsonProperty(PropertyName = "i")]
        public string ImdbId { get; set; }

        /// <summary>
        /// Movie title to search for.

        /// </summary>
        [JsonProperty(PropertyName = "t")]
        public string MovieTitle { get; set; }

        /// <summary>
        /// Include Rotten Tomatoes ratings.

        /// </summary>
        [JsonProperty(PropertyName = "tomatoes")]
        public bool? IncludeRottenTomatoesRatings { get; set; }

        /// <summary>
        /// Return short or full plot.
        /// </summary>
        [JsonProperty(PropertyName = "plot")]
        public Enumerator.Plot? Plot { get; set; }

     
    }
}
