using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BracketShow.Client.Pages.About
{
    public partial class About
    {
        private readonly HttpClient Http;

        public About()
        {
        }

        public About(HttpClient httpClient) : this()
        {
            Http = httpClient;
        }
    }
}