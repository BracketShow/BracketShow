using System;
using System.Collections;

namespace Models.HomeViewModels
{
    public class VideoViewModel
    {
        public string YouTubeId => YouTubeUrl.Replace("https://www.youtube.com/watch?v=", "");

        public string YouTubeUrl { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
    }
}