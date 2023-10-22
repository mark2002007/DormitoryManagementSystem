using Microsoft.EntityFrameworkCore;

namespace EFCoreSQLiteDemo
{
    public class DormitoryContext : DbContext
    {
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<Faculty> Faculties { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dormitory.db");
        }
    }
}
