using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BracketShow.Shared;
using System.Collections.Generic;

namespace BracketShow.Client.Components
{
    public partial class PlaylistSection
    {
        private VideoInformation[] videos;

        [Parameter]
        public PlaylistInformation PlaylistInformation { get; set; }

        [Inject]
        public HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            videos = await Http.GetJsonAsync<VideoInformation[]>($"api/video/GetPlaylistVideos?playlistId={PlaylistInformation.Id}");
        }
    }
}