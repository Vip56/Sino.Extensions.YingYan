using Sino.Extensions.YingYan;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class YingYanServiceCollectionExtensions
    {
        public static IServiceCollection AddYingYan(this IServiceCollection services, string url, string ak, string serviceId)
        {
            return services.AddSingleton<IYingYanService>(new YingYanService(url, ak, serviceId));
        }
    }
}
