using System.Globalization;

namespace AppInitDemo.Initializers
{
    public static class ResourceInitializer
    {
        /// <summary>
        /// Initialize application Resource settings
        /// </summary>
        /// <param name="builder">WebApplicationBuilder</param>
        public static void Init(WebApplicationBuilder builder)
        {
            // perform some Resource configuration as an example
            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            var supportedCultures = new List<CultureInfo> { new CultureInfo("en-US") };

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            { 
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
        }
    }
}
