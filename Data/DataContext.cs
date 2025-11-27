using Microsoft.EntityFrameworkCore;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<UserModel> Users { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
