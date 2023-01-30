using BulkyBooks.Models;
using Microsoft.EntityFrameworkCore;


namespace BulkyWebBooks.DataAccess;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{

	}
	public DbSet<Category> Category { get; set; }
	public DbSet<CoverType> CoverTypes { get; set; }
	public DbSet<Product> Products { get; set; }

}