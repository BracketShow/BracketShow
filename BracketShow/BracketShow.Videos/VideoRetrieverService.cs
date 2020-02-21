using BracketShow.Videos.Abstractions;
using BracketShow.Videos.Domain;
using LazyCache;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BracketShow.Videos
{
    internal class VideoRetrieverService : IVideoRetrieverService
    {
        private readonly IVideoRetriever videoRetriever;
        private readonly IAppCache appCache;

        public VideoRetrieverService(IVideoRetriever videoRetriever, IAppCache appCache)
        {
            this.videoRetriever = videoRetriever;
            this.appCache = appCache;
        }

        public async Task<IEnumerable<PlaylistInformation>> GetChannelPlaylists()
        {            
            var channelPlaylists = await appCache.GetOrAddAsync("channelPlaylists", () => PopulateChannelPlaylistsCache(), DateTimeOffset.Now.AddHours(8));
            return channelPlaylists;

            async Task<IEnumerable<PlaylistInformation>> PopulateChannelPlaylistsCache()
            {
                IEnumerable<PlaylistInformation> playlists = await videoRetriever.GetChannelPlaylists();
                return playlists;
            }
        }

        public async Task<VideoInformation> GetLatestChannelVideo()
        {
            var retVal = await appCache.GetOrAddAsync("latestVideo", () => PopulateLatestVideoCache(), DateTimeOffset.Now.AddHours(8));
            return retVal;

            async Task<VideoInformation> PopulateLatestVideoCache()
            {
                var latestVideo = await videoRetriever.GetLatestChannelVideo();
                return latestVideo;
            }
        }

        
    }

    
}
