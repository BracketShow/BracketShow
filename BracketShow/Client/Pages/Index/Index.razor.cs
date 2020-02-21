using Microsoft.JSInterop;
using System.Threading.Tasks;
using BracketShow.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Net.Http;

namespace BracketShow.Client.Pages.Index
{
    public partial class Index
    {
        private IEnumerable<PlaylistInformation> playlists;

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Inject]
        public HttpClient Http { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("highlightMenu");
                await JSRuntime.InvokeVoidAsync("reloadFb", null);
                StateHasChanged();
            }
        }

        protected override async Task OnInitializedAsync()
        {
            playlists = await Http.GetJsonAsync<PlaylistInformation[]>("api/video/GetPlaylistInformation");
        }
    }
}
