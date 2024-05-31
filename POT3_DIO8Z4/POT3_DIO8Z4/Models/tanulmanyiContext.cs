using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace POT3_DIO8Z4.Models
{
    public partial class tanulmanyiContext : DbContext
    {
        public tanulmanyiContext()
        {
        }

        public tanulmanyiContext(DbContextOptions<tanulmanyiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beosztasok> Beosztasoks { get; set; } = null!;
        public virtual DbSet<Napok> Napoks { get; set; } = null!;
        public virtual DbSet<Oktatok> Oktatoks { get; set; } = null!;
        public virtual DbSet<Orak> Oraks { get; set; } = null!;
        public virtual DbSet<Savok> Savoks { get; set; } = null!;
        public virtual DbSet<Statusok> Statusoks { get; set; } = null!;
        public virtual DbSet<Tantárgyak> Tantárgyaks { get; set; } = null!;
        public virtual DbSet<Termek> Termeks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=tanulmanyi;User ID=hallgato;Password=Password123;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beosztasok>(entity =>
            {
                entity.HasKey(e => e.BeosztasId);

                entity.ToTable("Beosztasok");

                entity.Property(e => e.BeosztasId)
                    .ValueGeneratedNever()
                    .HasColumnName("beosztas_id");

                entity.Property(e => e.Beosztasnev)
                    .HasMaxLength(50)
                    .HasColumnName("beosztasnev");

                entity.Property(e => e.Elvart).HasColumnName("elvart");
            });

            modelBuilder.Entity<Napok>(entity =>
            {
                entity.HasKey(e => e.NapId);

                entity.ToTable("Napok");

                entity.Property(e => e.NapId)
                    .ValueGeneratedNever()
                    .HasColumnName("nap_id");

                entity.Property(e => e.Nap)
                    .HasMaxLength(50)
                    .HasColumnName("nap");
            });

            modelBuilder.Entity<Oktatok>(entity =>
            {
                entity.HasKey(e => e.OktatoId);

                entity.ToTable("Oktatok");

                entity.Property(e => e.OktatoId)
                    .ValueGeneratedNever()
                    .HasColumnName("oktato_id");

                entity.Property(e => e.Beosztás).HasColumnName("beosztás");

                entity.Property(e => e.Nev)
                    .HasMaxLength(50)
                    .HasColumnName("nev");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Titulus)
                    .HasMaxLength(50)
                    .HasColumnName("titulus");

                entity.HasOne(d => d.BeosztásNavigation)
                    .WithMany(p => p.Oktatoks)
                    .HasForeignKey(d => d.Beosztás)
                    .HasConstraintName("FK_Oktatok_Beosztasok");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Oktatoks)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK_Oktatok_statusok");
            });

            modelBuilder.Entity<Orak>(entity =>
            {
                entity.HasKey(e => e.OraId);

                entity.ToTable("Orak");

                entity.Property(e => e.OraId)
                    .ValueGeneratedNever()
                    .HasColumnName("ora_id");

                entity.Property(e => e.Nap).HasColumnName("nap");

                entity.Property(e => e.Tanar).HasColumnName("tanar");

                entity.Property(e => e.Targy).HasColumnName("targy");

                entity.Property(e => e.Terem).HasColumnName("terem");

                entity.HasOne(d => d.NapNavigation)
                    .WithMany(p => p.Oraks)
                    .HasForeignKey(d => d.Nap)
                    .HasConstraintName("FK_Orak_Napok");

                entity.HasOne(d => d.SavNavigation)
                    .WithMany(p => p.Oraks)
                    .HasForeignKey(d => d.Sav)
                    .HasConstraintName("FK_Orak_Savok");

                entity.HasOne(d => d.TanarNavigation)
                    .WithMany(p => p.Oraks)
                    .HasForeignKey(d => d.Tanar)
                    .HasConstraintName("FK_Orak_Oktatok");

                entity.HasOne(d => d.TargyNavigation)
                    .WithMany(p => p.Oraks)
                    .HasForeignKey(d => d.Targy)
                    .HasConstraintName("FK_Orak_Tantárgyak");

                entity.HasOne(d => d.TeremNavigation)
                    .WithMany(p => p.Oraks)
                    .HasForeignKey(d => d.Terem)
                    .HasConstraintName("FK_Orak_Termek");
            });

            modelBuilder.Entity<Savok>(entity =>
            {
                entity.HasKey(e => e.SavId);

                entity.ToTable("Savok");

                entity.Property(e => e.SavId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sav_id");

                entity.Property(e => e.Időpont).HasMaxLength(50);

                entity.Property(e => e.Sav).HasMaxLength(50);
            });

            modelBuilder.Entity<Statusok>(entity =>
            {
                entity.HasKey(e => e.Skod);

                entity.ToTable("statusok");

                entity.Property(e => e.Skod).ValueGeneratedNever();

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Tantárgyak>(entity =>
            {
                entity.HasKey(e => e.Tkód);

                entity.ToTable("Tantárgyak");

                entity.Property(e => e.Tkód).ValueGeneratedNever();

                entity.Property(e => e.Tantargykod).HasMaxLength(50);

                entity.Property(e => e.Tantárgynév).HasMaxLength(50);
            });

            modelBuilder.Entity<Termek>(entity =>
            {
                entity.HasKey(e => e.Tkód);

                entity.ToTable("Termek");

                entity.Property(e => e.Tkód).ValueGeneratedNever();

                entity.Property(e => e.Terem).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
