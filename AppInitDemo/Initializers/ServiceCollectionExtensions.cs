using AppInitDemo.Logic;
using Microsoft.AspNetCore.DataProtection;

namespace AppInitDemo.Initializers
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configure custom service registrations for the application
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ApplicationLogic>();
            services.AddSingleton<CachedData>();
        }

        /// <summary>
        /// Configure customer security settings for the application
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        public static void AddCustomSecurity(this IServiceCollection services)
        {
            services.AddAntiforgery(options =>
            {
                options.HeaderName = "InitializeCleanupDemo";
                options.Cookie.Name = "InitializeCleanupDemo";
                options.Cookie.SameSite = SameSiteMode.Strict;
                options.Cookie.HttpOnly = false;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            });

            services.AddDataProtection()
                .SetApplicationName("InitializeCleanupDemo");
        }
    }
}
