using Microsoft.EntityFrameworkCore;
using DormitoryManagementSystem.Models;

namespace DormitoryManagementSystem.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
    {
    }
    public DbSet<Resident> Residents { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Dormitory> Dormitories { get; set; }
    public DbSet<Faculty> Faculties { get; set; } 

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source=../Database/dormitory.db");
    // }
}
