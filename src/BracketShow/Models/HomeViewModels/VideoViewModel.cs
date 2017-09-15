using System;
using System.Collections;

namespace Models.HomeViewModels
{
    public class VideoViewModel
    {
        private string _image;
        public string YouTubeId => YouTubeUrl.Replace("https://www.youtube.com/watch?v=", "");

        public string YouTubeUrl { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }

        public string Image
        {
            get
            {
                if (_image == null)
                    return String.Format("http://img.youtube.com/vi/{0}/0.jpg", YouTubeId);
                return _image;
            }
            set { _image = value; }
        }
    }
}