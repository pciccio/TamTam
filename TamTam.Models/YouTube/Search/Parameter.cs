namespace TamTam.Models.YouTube.Search
{
    public class Parameter
    {
        public string key => API.Constants.ApiKey;

        public bool? forContentOwner { get; set; }
        
        public bool? forMine { get; set; }
     
        public string relatedToVideoId { get; set; }
        
        public string channelId { get; set; }
        
        public string channelType { get; set; }
        
        public string eventType { get; set; }
        
        public short? maxResults { get; set; }
        
        public string onBehalfOfContentOwner { get; set; }
        
        public string pageToken { get; set; }
        
        public string publishedAfter { get; set; }
        
        public string publishedBefore { get; set; }
        
        public string q { get; set; }
        
        public string regionCode { get; set; }
        
        public string safeSearch { get; set; }
        
        public string topicId { get; set; }
        
        public string videoCategoryId { get; set; }
        
        public Enumerator.Part part { get; set; }
        
        public Enumerator.Order order { get; set; }
        
        public Enumerator.Type type { get; set; }

        public Enumerator.VideoDefinition videoDefinition { get; set; }
        
        public Enumerator.VideoDimension videoDimension { get; set; }
        
        public Enumerator.VideoDuration videoDuration { get; set; }
        
        public Enumerator.VideoEmbeddable videoEmbeddable { get; set; }
        
        public Enumerator.VideoLicense videoLicense { get; set; }
        
        public Enumerator.VideoType videoType { get; set; }
    }
}