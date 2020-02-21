using BracketShow.Videos.Abstractions;
using BracketShow.Videos.Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BracketShow.Youtube
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddYoutubeVideoProvider(this IServiceCollection services, IConfigurationSection configuration)
        {
            services.Configure<VideoProviderOptions>(configuration);
            services.AddScoped<IVideoRetriever, YoutubeRetrieverService>();
            return services;
        }
    }
}
