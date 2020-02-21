using BracketShow.Videos.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BracketShow.Videos
{
    public interface IVideoRetrieverService
    {
        Task<VideoInformation> GetLatestChannelVideo();
        Task<IEnumerable<PlaylistInformation>> GetChannelPlaylists();
        Task<IEnumerable<VideoInformation>> GetPlaylistVideos(string playlistId);
    }
}
