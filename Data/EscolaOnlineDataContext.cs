using EscolaOnline.Api.Data.Mappings;
using EscolaOnline.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaOnline.Api.Data
{
    public class EscolaOnlineDataContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Professor> professors { get; set; }
        public DbSet<Admin> admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=EscolaOnlineDb;User ID=sa;Password=1q2w3e4r@#$");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new AdminMap());
        }
    }
}
