using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommonBusinessLogic
{
    public class YouTubeManager
    {
        public async Task<YouTubeResults> SearchYouTubeAsync(string searchText)
        {
          return await RunYouTubeSearch(searchText);        
        }

        private async Task<YouTubeResults> RunYouTubeSearch(string searchText)
        {
            YouTubeResults theResults = new YouTubeResults();
            theResults.SearchString = searchText;

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "#### your google key #######",  //// config file better loction for this
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = searchText;
            searchListRequest.MaxResults = 10; 

            var searchListResponse = searchListRequest.Execute();
            
            List<string> videos = new List<string>();            

            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        theResults.VideoResults.Add(new Video(searchResult.Id.VideoId, searchResult.Snippet.Title, searchResult.Snippet.Thumbnails.Default__.Url));
                        break;
                }
            }

            return theResults;
        }
    }
}
