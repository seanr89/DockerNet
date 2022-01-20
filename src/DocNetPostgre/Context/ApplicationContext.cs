
using DocNetPostgre.Models;
using Microsoft.EntityFrameworkCore;

namespace DocNetPostgre.Context;

public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions options)
				: base(options)
		{
		}

		public DbSet<Student> Students { get; set; }
}