using BracketShow.Videos.Abstractions;
using BracketShow.Videos.Domain;
using LazyCache;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BracketShow.Videos
{
    //internal class VideoRetrieverCachedService : IVideoRetrieverService
    //{
    //    private readonly IAppCache appCache;
    //    private readonly IVideoRetrieverService service;

    //    public VideoRetrieverCachedService(IAppCache appCache, IVideoRetrieverService service)
    //    {
    //        this.appCache = appCache;
    //        this.service = service;
    //    }
    //    public Task<IEnumerable<PlaylistInformation>> GetChannelPlaylists()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<VideoInformation> GetLatestChannelVideo()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<IEnumerable<VideoInformation>> GetPlaylistVideos(string playlistId)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

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
            return await appCache.GetOrAddAsync("channelPlaylists", () => PopulateChannelPlaylistsCache(), DateTimeOffset.Now.AddHours(8));

            async Task<IEnumerable<PlaylistInformation>> PopulateChannelPlaylistsCache()
            {
                return await videoRetriever.GetChannelPlaylists();
            }
        }

        public async Task<VideoInformation> GetLatestChannelVideo()
        {
            return await appCache.GetOrAddAsync("latestVideo", () => PopulateLatestVideoCache(), DateTimeOffset.Now.AddHours(8));

            async Task<VideoInformation> PopulateLatestVideoCache()
            {
                return await videoRetriever.GetLatestChannelVideo();
            }
        }

        public async Task<IEnumerable<VideoInformation>> GetPlaylistVideos(string playlistId)
        {
            return await appCache.GetOrAddAsync($"playlistVideos-{playlistId}", () => PopulatePlaylistVideosCache(), DateTimeOffset.Now.AddHours(8));

            async Task<IEnumerable<VideoInformation>> PopulatePlaylistVideosCache()
            {
                return await videoRetriever.GetPlaylistVideos(playlistId);
            }
        }
    }

    
}
