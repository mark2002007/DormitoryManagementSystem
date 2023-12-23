using Microsoft.EntityFrameworkCore;
using DormitoryManagementSystem.Models;

namespace DormitoryManagementSystem.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
    {
        
    }
    public DbSet<Rector> Rectors { get; set; }
    public DbSet<Dean> Deans { get; set; }
    public DbSet<Warden> Wardens { get; set; }
    public DbSet<Resident> Residents { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Dormitory> Dormitories { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Faculty>()
            .HasOne(f => f.Dean)
            .WithOne(d => d.Faculty)
            .HasForeignKey<Dean>(d => d.FacultyId);

        modelBuilder.Entity<Dean>()
            .HasOne(d => d.Faculty)
            .WithOne(f => f.Dean)
            .HasForeignKey<Faculty>(f => f.DeanId);
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source=../Database/dormitory.db");
    // }
}
