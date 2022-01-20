
using DocNetPostgre.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DocNetPostgre;

    public static class MigrationExtensions
    {
        /// <summary>
        /// Setup EFCore DB and Seed any data
        /// </summary>
        /// <param name="services"></param>
        public static void RunDBMigration(IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            var context = provider.GetRequiredService<ApplicationContext>();

            context.Database.Migrate();
        }
    }