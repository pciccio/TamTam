using System.ComponentModel;

namespace TamTam.Models.YouTube.Search
{
    public class Enumerator
    {

        public enum VideoType
        {
            [Description("any")]
            Any,
            [Description("episode")]
            Espisode,
            [Description("movie")]
            Movie
        }

        public enum VideoSyndicated
        {
            [Description("any")]
            Any,
            [Description("true")]
            True
        }

        public enum VideoLicense
        {
            [Description("any")]
            Any,
            [Description("creativeCommon")]
            CreativeCommon,
            [Description("youTube")]
            YouTube
        }

        public enum VideoEmbeddable
        {
            [Description("any")]
            Any,
            [Description("true")]
            True
        }

        public enum VideoDuration
        {
            [Description("any")]
            Any,
            [Description("long")]
            Long,
            [Description("medium")]
            Medium,
            [Description("short")]
            Short
        }

        public enum VideoDimension
        {
            [Description("any")]
            Any,
            [Description("2d")]
            TwoD,
            [Description("3d")]
            ThreeD,
        
        }

        public enum VideoDefinition
        {
            [Description("any")]
            Any,
            [Description("high")]
            High,
            [Description("standard")]
            Standard
        }

        public enum VideoCaption
        {
            [Description("any")]
            Any,
            [Description("closedCaption")]
            ClosedCaption,
            [Description("none")]
            None
        }

        public enum Type
        {
            [Description("channel")]
            Channel,
            [Description("playlist")]
            Playlist,
            [Description("video")]
            Video
        }

        public enum Order
        {
            [Description("date")]
            Date,
            [Description("rating")]
            Rating,
            [Description("relevance")]
            Relevance,
            [Description("title")]
            Title,
            [Description("videoCount")]
            VideoCount,
            [Description("viewCount")]
            ViewCount
        }

        public enum Part
        {
            [Description("snippet")]
            Snippet,
            [Description("iescription")]
            Id
        }
    }
}
