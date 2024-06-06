using ex03.Models;
using Microsoft.EntityFrameworkCore;

namespace ex03.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<Cajero> Cajeros { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<MaquinaRegistradora> MaquinasRegistradoras { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venta>()
        .HasKey(v => new { v.CajeroCodigo, v.ProductoCodigo, v.MaquinaCodigo });

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cajero)
                .WithMany(c => c.Ventas)
                .HasForeignKey(v => v.CajeroCodigo)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Producto)
                .WithMany(p => p.Ventas)
                .HasForeignKey(v => v.ProductoCodigo)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Maquina)
                .WithMany(m => m.Ventas)
                .HasForeignKey(v => v.MaquinaCodigo)
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