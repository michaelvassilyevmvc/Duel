using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IDbContext
    {
        public DbSet<Topic> Topics { get; }
        public DbSet<Disputer> Disputers { get; }
        public DbSet<Theme> Themes { get;  }
        public DbSet<TopicDisputer> TopicDisputers { get; }

        Task<int> SaveChangesAsync(CancellationToken token = default);
    }
}