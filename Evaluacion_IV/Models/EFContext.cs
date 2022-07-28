using Microsoft.EntityFrameworkCore;

namespace Evaluacion_IV.Models
{
    public class EFContext : DbContext
    {
        private const string ConnectionString = "server=localhost;port=3306;database=evaluacion;user=root;password=;Connect Timeout=5";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8,0,11)));
        }
        
        public DbSet<Estudio> Estudios { get; set; }
        public DbSet<Juego> Juegos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Claves primarias
            modelBuilder.Entity<Estudio>().HasKey(i => i.Id);
            modelBuilder.Entity<Juego>().HasKey(j => j.Id);
            
            //Relaciones
            modelBuilder.Entity<Juego>()
                .HasOne<Estudio>(j => j.Estudio)
                .WithMany(e => e.Juegos)
                .HasForeignKey(j => j.EstudioId);
            
            //Obligatorios
            //Estudio
            modelBuilder.Entity<Estudio>().Property(e => e.Nombre).IsRequired();
            modelBuilder.Entity<Estudio>().Property(e => e.Fundacion).IsRequired();
            modelBuilder.Entity<Estudio>().Property(e => e.Consola).IsRequired();
            
            //Juego
            modelBuilder.Entity<Juego>().Property(j => j.EstudioId).IsRequired();
            modelBuilder.Entity<Juego>().Property(j => j.Nombre).IsRequired();
            modelBuilder.Entity<Juego>().Property(j => j.UnidadesVendidas).IsRequired();
        }
    }
}

