using EntitiesTesteCandidato;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InfraTesteCandidato.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public virtual DbSet<Motorista> Motorista { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Cache;Integrated Security=False;Encrypt=False;TrustServerCertificate=False");
                base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Motorista>(entity =>
            {
                entity.HasKey(e => new { e.Id });
                entity.Property(e => e.Id).HasColumnName("Id");
                entity.Property(e => e.Nome)
                  .HasMaxLength(500);
                entity.Property(e => e.marca)
                  .HasMaxLength(500);
                entity.Property(e => e.modelo)
                  .HasMaxLength(500);
                entity.Property(e => e.placa)
                  .HasMaxLength(500);
                entity.Property(e => e.eixos)
                  .HasMaxLength(500);
                entity.Property(e => e.logradouro)
                  .HasMaxLength(500);
                entity.Property(e => e.cep)
                  .HasMaxLength(9);
                entity.Property(e => e.logradouro)
                  .HasMaxLength(500);
                entity.Property(e => e.complemento)
                  .HasMaxLength(500);
                entity.Property(e => e.bairro)
                  .HasMaxLength(500);
                entity.Property(e => e.localidade)
                  .HasMaxLength(500);
                entity.Property(e => e.uf).HasColumnType("char");      
            });
        }
    }
}
