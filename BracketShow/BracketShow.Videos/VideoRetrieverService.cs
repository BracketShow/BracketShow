using BracketShow.Videos.Abstractions;
using BracketShow.Videos.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BracketShow.Videos
{
    internal class VideoRetrieverService : IVideoRetrieverService
    {
        private readonly IVideoRetriever videoRetriever;

        public VideoRetrieverService(IVideoRetriever videoRetriever)
        {
            this.videoRetriever = videoRetriever;
        }

        public IEnumerable<VideoPlaylist> GetChannelPlaylists()
        {
            throw new NotImplementedException();
        }

        public async Task<VideoInformation> GetLatestChannelVideo()
        {
            return await videoRetriever.GetLatestChannelVideo();
        }
    }

    
}
