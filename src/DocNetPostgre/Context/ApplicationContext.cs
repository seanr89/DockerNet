
using DocNetPostgre.Models;
using Microsoft.EntityFrameworkCore;

namespace DocNetPostgre.Context;

public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
				: base(options)
		{
		}

		public DbSet<Student> Students { get; set; }
}