namespace CommonBusinessLogic
{
    public class Video : IVideo
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string ThumbnailLink { get; set; }

        public Video(string id, string title, string thumbnailLink)
        {
            Id = id;
            Title = title;
            ThumbnailLink = thumbnailLink;
        }
    }
}
