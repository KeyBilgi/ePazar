using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Entities.Congrete;

namespace BulutWebApi
{
    public partial class malpazariContext : DbContext
    {
        public virtual DbSet<Blt0101Users> Blt0101Users { get; set; }

        // Unable to generate entity type for table 'dbo.blt_01_01_product'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=malpazari;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blt0101Users>(entity =>
            {
                entity.ToTable("blt_01_01_users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adres)
                    .HasColumnName("adres")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cinsiyet).HasColumnName("cinsiyet");

                entity.Property(e => e.Egitimdurum)
                    .HasColumnName("egitimdurum")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Firmaid).HasColumnName("firmaid");

                entity.Property(e => e.Kod)
                    .HasColumnName("kod")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Medenihal).HasColumnName("medenihal");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("phonenumber")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}