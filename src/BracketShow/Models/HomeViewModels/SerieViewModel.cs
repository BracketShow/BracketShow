using System.Collections.Generic;

namespace Models.HomeViewModels
{
    public class SerieViewModel
    {
        public string Category { get; set; }
        public IEnumerable<VideoViewModel> Videos { get; set; }
    }
}