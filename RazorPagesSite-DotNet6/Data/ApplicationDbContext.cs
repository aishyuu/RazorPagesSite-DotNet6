using Microsoft.EntityFrameworkCore;
using RazorPagesSite_DotNet6.Model;

namespace RazorPagesSite_DotNet6.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
}
