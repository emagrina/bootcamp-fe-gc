using ex02.Models;
using Microsoft.EntityFrameworkCore;

namespace ex02.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Asignado_A> Asignados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Asignado_A>()
                .HasKey(aa => aa.Id);

            modelBuilder.Entity<Asignado_A>()
                .HasOne(aa => aa.Cientifico)
                .WithMany(c => c.Asignados)
                .HasForeignKey(aa => aa.CientificoDni);

            modelBuilder.Entity<Asignado_A>()
                .HasOne(aa => aa.Proyecto)
                .WithMany(p => p.Asignados)
                .HasForeignKey(aa => aa.ProyectoId);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = configuration.GetConnectionString("MySqlConnection");
            var serverVersion = new MySqlServerVersion(new Version(10, 11, 2));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
