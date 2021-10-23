using Microsoft.Extensions.DependencyInjection;
using MyToDoApp.Service;
using System;
using System.Net.Http;

namespace MyToDoApp.Config
{
    public static class AddHostedServiceConfiguration
    {
        public static void AddHostedService(this IServiceCollection services)
        {
            services.AddHostedService<TimedHostedService>();

            var endPointA = new Uri("http://localhost:44308/"); // this is the endpoint HttpClient will hit

            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = endPointA,
            };

            // ServicePointManager.FindServicePoint(endPointA).ConnectionLeaseTimeout = 60000; // sixty seconds

            services.AddSingleton<HttpClient>(httpClient);
        }
    }
}
