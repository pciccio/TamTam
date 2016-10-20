using Newtonsoft.Json;

namespace TamTam.Models.OMDb.Search
{
    public class ParameterBySearch : ParameterBase
    {
        /// <summary>
        /// Movie title to search for.
        /// </summary>
        [JsonProperty(PropertyName = "s")]
        public string MovieTitle { get; set; }
    }
}
