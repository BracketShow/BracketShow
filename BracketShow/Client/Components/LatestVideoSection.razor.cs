//using System;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Components;
//using BracketShow.Shared;

//namespace BracketShow.Client.Components
//{
//    public partial class LatestVideoSection : ComponentBase
//    {
//        private readonly HttpClient Http;
//        private VideoInformation latestVideo;

//        public LatestVideoSection()
//        {
//        }

//        public LatestVideoSection(HttpClient httpClient) : this()
//        {
//            Http = httpClient;
//        }

//        protected override async Task OnInitializedAsync()
//        {
//            latestVideo = await Http.GetJsonAsync<VideoInformation>("video");
//        }
//    }
//}