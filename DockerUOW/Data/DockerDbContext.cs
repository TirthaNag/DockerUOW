using DockerUOW.Entities;
using Microsoft.EntityFrameworkCore;

namespace DockerUOW.Data
{
    public class DockerDbContext : DbContext
    {
        public DockerDbContext(DbContextOptions<DockerDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<StudentEntity> Student { get; set; }
    }
}
