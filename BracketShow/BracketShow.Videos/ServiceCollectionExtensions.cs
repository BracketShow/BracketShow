using Microsoft.Extensions.DependencyInjection;

namespace BracketShow.Videos
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddVideoRetrieving(this IServiceCollection services)
        {
            services.AddScoped<IVideoRetrieverService, VideoRetrieverService>();
            return services;
        }
    }
}
