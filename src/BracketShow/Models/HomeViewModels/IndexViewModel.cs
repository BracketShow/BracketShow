using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Models.HomeViewModels
{
    public class IndexViewModel
    {
        private readonly string _id;
        private readonly IEnumerable<VideoViewModel> _videos;

        public IndexViewModel(string id)
        {
            _id = id;
            var text = File.ReadAllText(@"wwwroot\data.json");
            var videoViewModels = JsonConvert.DeserializeObject<List<VideoViewModel>>(text);
            _videos = videoViewModels;
        }

        public VideoViewModel Featured
        {
            get
            {
                VideoViewModel videoToShow = null;
                if (_id != null) videoToShow = _videos.FirstOrDefault(v => v.YouTubeId == _id);
                return videoToShow ?? (from video in _videos
#if DEBUG
                           where video.PublishDate <= DateTime.Now
#endif                             
                           orderby video.PublishDate descending
                           select video).First();
            }
        }

        public bool FeaturedVideoSelected => _id != null;

        public IEnumerable<SerieViewModel> Series
        {
            get
            {
                var serieViewModels = from video in _videos
                    where video.PublishDate <= DateTime.Now
                    group video by video.Category
                    into g
                    select new SerieViewModel
                    {
                        Category = g.Key,
                        Videos = g
                    };
                return serieViewModels;
            }
        }
    }
}