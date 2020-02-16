using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BracketShow.Client.Pages.Contact
{
    public partial class Contact
    {
        private readonly HttpClient Http;

        public Contact()
        {
        }

        public Contact(HttpClient httpClient) : this()
        {
            Http = httpClient;
        }
    }
}