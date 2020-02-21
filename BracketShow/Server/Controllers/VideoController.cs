using BracketShow.Shared;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BracketShow.Videos;

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
    }
}
