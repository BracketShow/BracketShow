using BracketShow.Videos.Abstractions;
using BracketShow.Videos.Domain;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
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

        private void truc()
        {
            var yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = "AIzaSyC-oe1mC2E0mwDPOgE8PyUwacNC-4gnHa4" });

            var truc = yt.Playlists.List("snippet,contentDetails");
            truc.ChannelId = "UCtnYlMKv9vbV6EITjrCwr1g";

            // all playlists
            var results = truc.Execute();
            // results.Items[0].Snippet.Title


            
        }

        public IEnumerable<VideoPlaylist> GetChannelPlaylists()
        {
            throw new NotImplementedException();
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
