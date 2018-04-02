using CommonBusinessLogic;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class YouTubeController : ApiController
    {        
        public IEnumerable<Video> Get(string searchText)
        {
            var u = new YouTubeManager();
            var r = u.SearchYouTubeAsync(searchText);                           

            return r.Result.VideoResults;                        
        }        
    }
}
