namespace TamTam.Models.YouTube.Result
{
    public class Id
    {
        public string kind { get; set; }
        public string videoId { get; set; }

        private string src => string.Concat("https://www.youtube.com/embed/", videoId);
        
        public string embed => string.Format("<iframe width=\"{0}\" height=\"{1}\" src=\"{2}\" frameborder=\"{3}\" allowfullscreen></iframe>", 420, 240, src, 0);
    }
}
