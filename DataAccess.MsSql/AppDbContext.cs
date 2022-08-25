using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.MsSql
{
    public class AppDbContext : DbContext, IDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Disputer> Disputers { get; set; }
        public DbSet<TopicDisputer> TopicDisputers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TopicDisputer>(x => x.HasKey(a => new { a.TopicId, a.DisputerId }));

            modelBuilder.Entity<TopicDisputer>()
                .HasOne(x => x.Topic)
                .WithMany(x => x.Disputers)
                .HasForeignKey(x => x.TopicId);

            modelBuilder.Entity<TopicDisputer>()
                .HasOne(x => x.Disputer)
                .WithMany(x => x.Topics)
                .HasForeignKey(x => x.DisputerId);
        }
    }
}