using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BracketShow.Shared;

namespace BracketShow.Client.Components
{
    public partial class PlaylistSection
    {
        [Parameter]
        public PlaylistInformation PlaylistInformation { get; set; }

        [Inject]
        public HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //latestVideo = await Http.GetJsonAsync<VideoInformation>("video/GetLatestVideo");
        }
    }
}