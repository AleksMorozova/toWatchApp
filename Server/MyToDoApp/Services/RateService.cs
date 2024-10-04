using MyToDoApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyToDoApp.Services
{
    public class RateService : IRateService
    {
        private HttpClient _client;

        public RateService(HttpClient client)
        {
            _client = client;
        }

        public async Task<int> GetRate()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("https://localhost:44354/rate");
                response.EnsureSuccessStatusCode();    // Throw if not a success code.
                var rate = await response.Content.ReadAsStringAsync();
                return Int32.Parse(rate);
            }
            catch (HttpRequestException e)
            {
                // Handle exception.
                return -1;
            }
        }
    }
}
