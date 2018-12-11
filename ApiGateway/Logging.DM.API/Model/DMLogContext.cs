using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Logging.DM.API.Model
{
    public partial class DMLogContext : DbContext
    {
        public DMLogContext()
        {
        }

        public DMLogContext(DbContextOptions<DMLogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EventLogs> EventLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventLogs>(entity =>
            {
                entity.Property(e => e.Level).HasMaxLength(128);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });
        }
    }
}
