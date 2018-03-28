namespace TesteCRUD_SPED.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContext")
        {
        }

        public virtual DbSet<ESTADOS_IBGE> Estados { get; set; }
        public virtual DbSet<MUNICIPIOS_IBGE> Municipios { get; set; }
        public virtual DbSet<PAISES_IBGE> Paises { get; set; }
        public virtual DbSet<PARTICIPANTE> Participantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ESTADOS_IBGE>()
                .Property(e => e.SIGLA_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS_IBGE>()
                .HasMany(e => e.MUNICIPIOS_IBGE)
                .WithRequired(e => e.ESTADOS_IBGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUNICIPIOS_IBGE>()
                .Property(e => e.COD_MUNICIPIO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIOS_IBGE>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<PAISES_IBGE>()
                .Property(e => e.COD_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<PAISES_IBGE>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<PAISES_IBGE>()
                .HasMany(e => e.PARTICIPANTE)
                .WithRequired(e => e.PAISES_IBGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.REG)
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.COD_PART)
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.COD_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.CNPJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.CPF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.COD_MUN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.SUFRAMA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.END)
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.NUM)
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.COMPL)
                .IsUnicode(false);

            modelBuilder.Entity<PARTICIPANTE>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);
        }
    }
}
