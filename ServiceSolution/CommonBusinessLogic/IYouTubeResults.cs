using System.Collections.Generic;

namespace CommonBusinessLogic
{
    public interface IYouTubeResults
    {
        string SearchError { get; set; }
        string SearchString { get; set; }
        List<Video> VideoResults { get; set; }
    }
}