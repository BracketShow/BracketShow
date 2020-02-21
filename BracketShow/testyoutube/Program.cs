using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;

namespace testyoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            var yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = "" });

            var truc = yt.Playlists.List("snippet,contentDetails");
            truc.ChannelId = "UCtnYlMKv9vbV6EITjrCwr1g";

            // all playlists
            var results = truc.Execute();
            // results.Items[0].Snippet.Title


            var latest = yt.Search.List("snippet");
            latest.ChannelId = "UCtnYlMKv9vbV6EITjrCwr1g";
            latest.Order = SearchResource.ListRequest.OrderEnum.Date;
            latest.MaxResults = 1;
            latest.Type = "video";

            var latestResult = latest.Execute();

            var test = "";

        }
    }
}
