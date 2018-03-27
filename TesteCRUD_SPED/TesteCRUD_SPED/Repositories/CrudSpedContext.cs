namespace TesteCRUD_SPED.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CrudSpedContext : DbContext
    {
        public CrudSpedContext()
            : base("name=CrudSpedContext")
        {
        }

        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }
        public virtual DbSet<Participante> Participantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>()
                .Property(e => e.SIGLA_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.MUNICIPIOS_IBGE)
                .WithRequired(e => e.ESTADOS_IBGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Municipio>()
                .Property(e => e.COD_MUNICIPIO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Municipio>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.COD_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.PARTICIPANTEs)
                .WithRequired(e => e.Pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.REG)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.COD_PART)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.COD_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.CNPJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.CPF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.COD_MUN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.SUFRAMA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.END)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.NUM)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.COMPL)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);
        }
    }
}
