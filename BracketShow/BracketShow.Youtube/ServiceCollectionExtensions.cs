using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BracketShow.Youtube
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddYoutube(this IServiceCollection services)
        {
            services.AddScoped<IYoutubeService, YoutubeService>();
            return services;
        }
    }
}
