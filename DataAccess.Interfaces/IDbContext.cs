using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IDbContext
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Disputer> Disputers { get; set; }
        public DbSet<TopicDisputer> TopicDisputers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken token);
    }
}