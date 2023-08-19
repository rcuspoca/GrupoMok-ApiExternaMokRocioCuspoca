using APINetMok.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace APINetMok.Dominio.Contextos
{
    public class PersistenciaContext : DbContext
    {
        public PersistenciaContext(DbContextOptions<PersistenciaContext> options) : base(options) { }

        public DbSet<TipoIdentificacionEntity> TipoIdentificacionEntity { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoIdentificacionEntity>().HasKey(x => new { x.IdTipoIdentificacion});           
        }
    }
}
