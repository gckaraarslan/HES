using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;    //bunu düzelt
using HES;

public class HESContext : DbContext
{
    public DbSet<Profile>? Profiles { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Report> Reports {get;set;}
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=HES;user=root;port=3306;password=toortoor", serverVersion);
    }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ProfileDatabaseBuilder.TableBuilder(modelBuilder);
        AddressDatabaseBuilder.TableBuilder(modelBuilder);
        ReportDatabaseBuilder.TableBuilder(modelBuilder);
       
    }
}