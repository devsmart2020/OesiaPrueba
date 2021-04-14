using Microsoft.EntityFrameworkCore;
using Oesia.Domain.Entities;

#nullable disable

namespace Oesia.Infrastructure.Data.Data
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<TbAuthor>(entity =>
            {
                entity.HasKey(e => e.AuthorId);

                entity.ToTable("TbAuthor");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.TbAuthors)
                    .HasForeignKey(d => d.City)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAuthor_TbCity");
            });

            modelBuilder.Entity<TbBook>(entity =>
            {
                entity.HasKey(e => e.IdBook);

                entity.ToTable("TbBook");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WriteDate).HasColumnType("date");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.TbBooks)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBook_TbAuthor");
            });

            modelBuilder.Entity<TbCity>(entity =>
            {
                entity.HasKey(e => e.IdCity);

                entity.ToTable("TbCity");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.TbCities)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbCity_TbCountry");
            });

            modelBuilder.Entity<TbCountry>(entity =>
            {
                entity.HasKey(e => e.IdCountry);

                entity.ToTable("TbCountry");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

        }
    }
}
