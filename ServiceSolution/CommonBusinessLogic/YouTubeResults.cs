using System.Collections.Generic;

namespace CommonBusinessLogic
{
    public class YouTubeResults : IYouTubeResults
    {
        public string SearchString { get; set; }

        public string SearchError { get; set; }

        public List<Video> VideoResults { get; set; }

        public YouTubeResults()
        {
            VideoResults = new List<Video>();
        }        
    }
}
