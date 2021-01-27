using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DrawMap.Models.DB
{
    public partial class BasarsoftContext : DbContext
    {
        public BasarsoftContext()
        {
        }

        public BasarsoftContext(DbContextOptions<BasarsoftContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblKapı> TblKapı { get; set; }
        public virtual DbSet<TblMahalle> TblMahalle { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=GOZDEPC\\SQLEXPRESS;Database=Basarsoft;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblKapı>(entity =>
            {
                entity.HasKey(e => e.KapıId);

                entity.Property(e => e.KapıId).HasColumnName("Kapı_id");

                entity.Property(e => e.MahalleCode)
                    .IsRequired()
                    .HasColumnName("Mahalle_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblMahalle>(entity =>
            {
                entity.HasKey(e => e.MahalleCode);

                entity.Property(e => e.MahalleCode)
                    .HasColumnName("Mahalle_code")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MahalleId)
                    .HasColumnName("Mahalle_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MahalleName)
                    .HasColumnName("Mahalle_name")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhotoPath).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasColumnName("User_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Username1)
                    .HasColumnName("Username")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
