using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): DbContext(options)
{
    public DbSet<Department> Departments {get; set;}
    public DbSet<Employee> Employees {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
        .HasIndex(d=>d.Name)
        .IsUnique();

        modelBuilder.Entity<Department>(x=>x.Property(e=> e.CreatedAt).HasDefaultValueSql("now()"));
    }
}
