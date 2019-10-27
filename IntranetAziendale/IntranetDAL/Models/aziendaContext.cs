using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IntranetDAL.Models
{
    public partial class aziendaContext : DbContext
    {
        public aziendaContext()
        {
        }

        public aziendaContext(DbContextOptions<aziendaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Convenzione> Convenzione { get; set; }
        public virtual DbSet<Dipendente> Dipendente { get; set; }
        public virtual DbSet<Ruolo> Ruolo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=azienda");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Convenzione>(entity =>
            {
                entity.ToTable("convenzioni", "azienda");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descrizione)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Titolo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dipendente>(entity =>
            {
                entity.ToTable("dipendente", "azienda");

                entity.HasIndex(e => e.Idruolo)
                    .HasName("IDRuolo");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cognome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idruolo)
                    .HasColumnName("IDRuolo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Psw)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdruoloNavigation)
                    .WithMany(p => p.Dipendente)
                    .HasForeignKey(d => d.Idruolo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dipendente_ibfk_1");
            });

            modelBuilder.Entity<Ruolo>(entity =>
            {
                entity.ToTable("ruolo", "azienda");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
