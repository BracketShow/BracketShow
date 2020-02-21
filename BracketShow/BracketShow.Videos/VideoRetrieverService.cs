using BracketShow.Videos.Abstractions;
using BracketShow.Videos.Domain;
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

        public async Task<IEnumerable<PlaylistInformation>> GetChannelPlaylists()
        {
            return await videoRetriever.GetChannelPlaylists();
        }

        public async Task<VideoInformation> GetLatestChannelVideo()
        {
            return await videoRetriever.GetLatestChannelVideo();
        }
    }

    
}
