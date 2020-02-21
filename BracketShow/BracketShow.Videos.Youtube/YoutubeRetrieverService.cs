using BracketShow.Videos.Abstractions;
using BracketShow.Videos.Domain;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BracketShow.Youtube
{
    internal class YoutubeRetrieverService : IVideoRetriever
    {
        private YouTubeService youtubeService;
        private readonly string channelId;

        public YoutubeRetrieverService(IOptions<VideoProviderOptions> options)
        {
            youtubeService = new YouTubeService(new BaseClientService.Initializer() { ApiKey = options.Value.ApiKey });
            channelId = options.Value.ChannelId;
        }
        
        public async Task<IEnumerable<PlaylistInformation>> GetChannelPlaylists()
        {
            var playlists = new List<PlaylistInformation>();

            var playlistRequest = youtubeService.Playlists.List("id,snippet");
            playlistRequest.ChannelId = channelId;
            playlistRequest.MaxResults = 50;

            var playlistResponse = await playlistRequest.ExecuteAsync();
            foreach (var playlist in playlistResponse.Items)
            {
                playlists.Add(new PlaylistInformation
                {
                    Id = playlist.Id,
                    Title = playlist.Snippet.Title
                });
            }

            return playlists;
        }

        public async Task<VideoInformation> GetLatestChannelVideo()
        {
            var latestRequest = youtubeService.Search.List("snippet");
            latestRequest.ChannelId = channelId;
            latestRequest.Order = SearchResource.ListRequest.OrderEnum.Date;
            latestRequest.MaxResults = 1;
            latestRequest.Type = "video";

            var latestResponse = await latestRequest.ExecuteAsync();

            return new VideoInformation
            {
                Id = latestResponse.Items[0].Id.VideoId
            };
        }
    }
}
