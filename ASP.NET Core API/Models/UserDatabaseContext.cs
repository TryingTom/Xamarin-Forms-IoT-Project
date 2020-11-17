using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;

namespace ASP.NET_Core_Api.Models
{
    public partial class UserDatabaseContext : DbContext
    {
        public UserDatabaseContext()
        {
        }

        public UserDatabaseContext(DbContextOptions<UserDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.MeasurementType).HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.HeightCm).HasColumnName("HeightCM");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.WeightKg).HasColumnName("WeightKG");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
