using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BracketShow.Client.Components
{
    public partial class LatestVideoSection
    {
        private readonly HttpClient Http;

        public LatestVideoSection()
        {
        }

        public LatestVideoSection(HttpClient httpClient) : this()
        {
            Http = httpClient;
        }
    }
}