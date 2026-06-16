using Domain;
using Microsoft.EntityFrameworkCore;


namespace Persistence;
public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
{
    public DbSet<Activity> Activitys { get; set; }
}
 
