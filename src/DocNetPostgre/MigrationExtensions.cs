
using DocNetPostgre.Context;
using DocNetPostgre.Models;
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
            SeedStudentData(context);
        }

        /// <summary>
        /// Support Tests to see how data seeding works!
        /// </summary>
        /// <param name="context"></param>
        static void SeedStudentData(ApplicationContext context)
        {
            if(!context.Students.Any())
            {
                context.Students.Add(new Student { Name = "Sean Rafferty", Age = 35, Active = true });
                context.Students.Add(new Student { Name ="John Smith", Age = 15, Active = true });
                context.Students.Add(new Student { Name ="Francy Donald", Age = 27, Active = true});

                context.SaveChanges();
            }
        }
    }