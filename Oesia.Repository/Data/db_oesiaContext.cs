using Microsoft.EntityFrameworkCore;
using Oesia.Domain.Entities;

#nullable disable

namespace Oesia.Repository.Data
{
    public partial class db_oesiaContext : DbContext
    {
        public db_oesiaContext()
        {
        }

        public db_oesiaContext(DbContextOptions<db_oesiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAuthor> TbAuthors { get; set; }
        public virtual DbSet<TbBook> TbBooks { get; set; }
        public virtual DbSet<TbCity> TbCities { get; set; }
        public virtual DbSet<TbCountry> TbCountries { get; set; }
        public virtual DbSet<TbEditorial> TbEditorials { get; set; }
        public virtual DbSet<TbGender> TbGenders { get; set; }
        public virtual DbSet<TbState> TbStates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<TbAuthor>(entity =>
            {
                entity.ToTable("TbAuthor");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.TbAuthors)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAuthor_TbCity");

                entity.HasOne(d => d.IdGenderNavigation)
                    .WithMany(p => p.TbAuthors)
                    .HasForeignKey(d => d.IdGender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAuthor_TbGender");
            });

            modelBuilder.Entity<TbBook>(entity =>
            {
                entity.ToTable("TbBook");

                entity.Property(e => e.LaunchDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.WriteDate).HasColumnType("date");

                entity.HasOne(d => d.IdAuthorNavigation)
                    .WithMany(p => p.TbBooks)
                    .HasForeignKey(d => d.IdAuthor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBook_TbAuthor");

                entity.HasOne(d => d.IdEditorialNavigation)
                    .WithMany(p => p.TbBooks)
                    .HasForeignKey(d => d.IdEditorial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBook_TbEditorial");
            });

            modelBuilder.Entity<TbCity>(entity =>
            {
                entity.ToTable("TbCity");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdStateNavigation)
                    .WithMany(p => p.TbCities)
                    .HasForeignKey(d => d.IdState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbCity_TbState");
            });

            modelBuilder.Entity<TbCountry>(entity =>
            {
                entity.ToTable("TbCountry");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEditorial>(entity =>
            {
                entity.ToTable("TbEditorial");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbGender>(entity =>
            {
                entity.ToTable("TbGender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbState>(entity =>
            {
                entity.ToTable("TbState");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.TbStates)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbState_TbCountry");
            });

        }

    }
}
