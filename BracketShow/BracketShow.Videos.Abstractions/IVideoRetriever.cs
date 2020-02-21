using BracketShow.Videos.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BracketShow.Videos.Abstractions
{
    public interface IVideoRetriever
    {
        Task<VideoInformation> GetLatestChannelVideo();
        Task<IEnumerable<PlaylistInformation>> GetChannelPlaylists();
    }
}
