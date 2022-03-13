using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FileBenched;

class Program
{
    private static IConfigurationRoot Configuration { get; set; }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("\n");

        Configuration = LoadAppSettings();

        var serviceCollection = new ServiceCollection();
        RegisterAndInjectServices(serviceCollection, Configuration);
        //Initialise netcore dependency injection provider
        var serviceProvider = serviceCollection.BuildServiceProvider();
    }

    /// <summary>
        /// Query app settings json content
        /// </summary>
        /// <returns></returns>
        private static IConfigurationRoot LoadAppSettings()
        {
            try
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

                return config;
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Error trying to load app settings");
                return null;
            }
        }

        /// <summary>
        /// Prep/Configure Dependency Injection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        private static void RegisterAndInjectServices(IServiceCollection services, IConfiguration config)
        {
            services.AddLogging(logging =>
            {
                logging.AddConsole();
            }).Configure<LoggerFilterOptions>(options => options.MinLevel =
                                                LogLevel.Warning);
        }
}