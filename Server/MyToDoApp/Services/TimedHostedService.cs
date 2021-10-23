using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public class TimedHostedService : IHostedService, IDisposable
    {
        // private readonly ILogger<TimedHostedService> _logger;
        private Timer _timer;
        private HttpClient _httpClient;
        public TimedHostedService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private async void DoWork(object state)
        {
            var result = await _httpClient.GetAsync("https://localhost:44308/Books/all");
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
