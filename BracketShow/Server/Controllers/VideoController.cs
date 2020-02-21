using BracketShow.Shared;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BracketShow.Videos;
using System.Collections.Generic;
using System.Linq;

namespace BracketShow.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly ILogger<VideoController> logger;
        private readonly IVideoRetrieverService videoRetrieverService;

        public VideoController(ILogger<VideoController> logger, IVideoRetrieverService videoRetrieverService)
        {
            this.logger = logger;
            this.videoRetrieverService = videoRetrieverService;
        }

        [HttpGet]
        public async Task<VideoInformation> GetLatestVideo()
        {
            var latestVideo = await videoRetrieverService.GetLatestChannelVideo();
            return new VideoInformation {
                Id = latestVideo.Id
            };
        }

        [HttpGet]
        public async Task<IEnumerable<PlaylistInformation>> GetPlaylistInformation()
        {
            var playlists = await videoRetrieverService.GetChannelPlaylists();
            return playlists.Select(p => new PlaylistInformation
            {
                Id = p.Id,
                Title = p.Title
            });
        }
    }
}
