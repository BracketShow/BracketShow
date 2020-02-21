using System.Net.Http;

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