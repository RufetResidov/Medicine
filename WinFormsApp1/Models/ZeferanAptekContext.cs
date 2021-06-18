using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApteklerSebekesi.Models
{
    public partial class ZeferanAptekContext : DbContext
    {
        public ZeferanAptekContext()
        {
        }

        public ZeferanAptekContext(DbContextOptions<ZeferanAptekContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<MedicineToTag> MedicineToTags { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DG0OTNT;Initial Catalog=ZeferanAptek;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Azeri_Latin_100_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Firm>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.Property(e => e.FId).HasColumnName("F_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.HasKey(e => e.MId);

                entity.Property(e => e.MId).HasColumnName("M_ID");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ExperienceDate).HasColumnType("datetime");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.MedicineName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Prodate).HasColumnType("datetime");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.Medicines)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicines_Firms");
            });

            modelBuilder.Entity<MedicineToTag>(entity =>
            {
                entity.ToTable("Medicine_To_Tags");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MedicineId).HasColumnName("MedicineID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.MedicineToTags)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicine_To_Tags_Medicines");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.MedicineToTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicine_To_Tags_Tags");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OId);

                entity.Property(e => e.OId).HasColumnName("O_ID");

                entity.Property(e => e.MedicineId).HasColumnName("MedicineID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Medicines");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Workers");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.TId);

                entity.Property(e => e.TId).HasColumnName("T_ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.WId);

                entity.Property(e => e.WId).HasColumnName("W_ID");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
