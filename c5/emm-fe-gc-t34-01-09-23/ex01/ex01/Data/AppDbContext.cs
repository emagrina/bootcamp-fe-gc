using ex01.Models;
using Microsoft.EntityFrameworkCore;

namespace ex01.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<Pieza> Piezas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Suministra> Suministra { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suministra>()
                .HasKey(s => new { s.CodigoPieza, s.IdProveedor });

            modelBuilder.Entity<Suministra>()
                .HasOne(s => s.Pieza)
                .WithOne(p => p.Suministra)
                .HasForeignKey<Suministra>(s => s.CodigoPieza)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Suministra>()
                .HasOne(s => s.Proveedor)
                .WithOne(p => p.Suministra)
                .HasForeignKey<Suministra>(s => s.IdProveedor)
                .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = configuration.GetConnectionString("MySqlConnection");
            var serverVersion = new MySqlServerVersion(new Version(10, 11, 2));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}