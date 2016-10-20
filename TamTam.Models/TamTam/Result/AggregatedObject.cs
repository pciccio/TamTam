using TamTam.Models.OMDb.Result;

namespace TamTam.Models.TamTam.Result
{
    public class AggregatedObject
    {
        public Movie Movie { get; set; }

        public YouTube.Result.Result Video { get; set; } 
    }
}
