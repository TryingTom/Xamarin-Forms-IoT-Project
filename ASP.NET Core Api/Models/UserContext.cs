using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ASP.NET_Core_Api.Models
{
    public partial class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<User> User { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //  ---- setup fluent API ---- //
            // set keys
            builder.Entity<User>()
                .HasKey(k => k.Id);
            builder.Entity<Log>()
                .HasKey(k => k.Id);
            
            // Set relations
            builder.Entity<Log>()
                .HasOne<User>(l => l.User)
                .WithMany(u => u.Logs)
                .HasForeignKey(l => l.UserId);
        }
    }
}
