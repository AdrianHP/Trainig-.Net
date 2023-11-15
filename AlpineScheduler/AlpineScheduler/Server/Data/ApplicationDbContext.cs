using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AlpineScheduler.Shared.Models;
namespace AlpineScheduler.Server.Models;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //    optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AlpineDB; Integrated Security=True  ")
    //        .EnableSensitiveDataLogging(true);

    //}
    public DbSet<Job> Jobs { get; set; }
}
