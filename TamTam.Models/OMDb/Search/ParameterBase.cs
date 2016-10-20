using System;
using Newtonsoft.Json;

namespace TamTam.Models.OMDb.Search
{
    public abstract class ParameterBase
    {
        /// <summary>
        /// JSONP callback name.
        /// </summary>
        [JsonProperty(PropertyName = "callback")]
        public string CallBack { get; set; }

        /// <summary>
        /// API version (reserved for future use).
        /// </summary>
        [JsonProperty(PropertyName = "v")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Year of release.
        /// </summary>        
        public DateTime? ReleaseDate { get; set; }

        [JsonProperty(PropertyName = "y")]
        public int? ReleaseYear
        {
            get
            {
                if(ReleaseDate != null)
                {
                    return ReleaseDate.Value.Year;
                }
                return null;
            }
        }

        /// <summary>
        /// Type of result to return.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public Enumerator.TypeOfResult? TypeOfResult { get; set; }

        /// <summary>
        /// The data type to return.
        /// </summary>
        [JsonProperty(PropertyName = "r")]
        public Enumerator.DataReturnType? DataReturnType { get; set; }
    }
}
