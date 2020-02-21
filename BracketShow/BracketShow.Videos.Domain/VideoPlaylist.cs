using System.Collections.Generic;

namespace BracketShow.Videos.Domain
{
    public class VideoPlaylist
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<VideoInformation> Videos { get; set; }
    }
}
